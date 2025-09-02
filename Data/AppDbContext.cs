using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Car> Cars { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Manufacturer Table Config
            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.HasKey(m => m.Id).HasName("manufacturers_pkey");

                entity.ToTable("Manufacturers", tb => tb.HasComment("Stores car manufacturer information."));

                entity.Property(m => m.Id)
                    .ValueGeneratedOnAdd()
                    .HasComment("Primary Key. Auto-incremented.");

                entity.Property(m => m.Name)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("Name of the manufacturer (e.g., Toyota, BMW).");

                entity.HasIndex(m => m.Name).IsUnique();

                entity.Property(m => m.Country)
                    .HasMaxLength(100)
                    .HasComment("Country where the manufacturer is based.");

                entity.Property(m => m.CreatedAt)
                    .HasDefaultValueSql("now()")
                    .HasColumnType("timestamp without time zone")
                    .HasComment("Timestamp when the manufacturer was created.");
            });

            // Car Table Config
            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(c => c.Id).HasName("cars_pkey");

                entity.ToTable("Cars", tb => tb.HasComment("Stores information about cars."));

                entity.Property(c => c.Id)
                    .ValueGeneratedOnAdd()
                    .HasComment("Primary Key. Auto-incremented.");

                entity.Property(c => c.Model)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasComment("Car model name (e.g., Corolla, X5).");

                entity.Property(c => c.Price)
                    .HasColumnType("decimal(18,2)")
                    .IsRequired()
                    .HasComment("Price of the car.");

                entity.Property(c => c.ManufactureYear)
                    .IsRequired()
                    .HasComment("Year the car was manufactured.");

                entity.Property(c => c.Stock)
                    .HasDefaultValue(0)
                    .HasComment("Number of cars available in stock.");

                entity.Property(c => c.CreatedAt)
                    .HasDefaultValueSql("now()")
                    .HasColumnType("timestamp without time zone")
                    .HasComment("Timestamp when the car was created.");

                // Foreign Key Relation
                entity.Property(c => c.ManufacturerId)
                    .IsRequired()
                    .HasComment("FK referencing the Manufacturer of this car.");

                entity.HasOne(c => c.Manufacturer)
                    .WithMany(m => m.Cars)
                    .HasForeignKey(c => c.ManufacturerId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("cars_manufacturerid_fkey");
            });

            DbSeeder.Seed(modelBuilder);
        }
    }
}

