using Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public static class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            // Seed Manufacturers
            List<Manufacturer> manufacturers =
            [
                new() { Id = 1, Name = "Toyota", Country = "Japan" },
                new() { Id = 2, Name = "BMW", Country = "Germany" },
                new() { Id = 3, Name = "Ford", Country = "USA" },
                new() { Id = 4, Name = "Honda", Country = "Japan" },
                new() { Id = 5, Name = "Hyundai", Country = "South Korea" },
                new() { Id = 6, Name = "Tata Motors", Country = "India" },
                new() { Id = 7, Name = "Mahindra", Country = "India" },
                new() { Id = 8, Name = "Maruti Suzuki", Country = "India" },
                new() { Id = 9, Name = "AvtoVAZ (Lada)", Country = "Russia" },
                new() { Id = 10, Name = "GAZ", Country = "Russia" }
            ];

            modelBuilder.Entity<Manufacturer>().HasData(manufacturers);

            // Seed Cars (at least 50 rows)
            List<Car> cars = [];
            Random random = new ();
            int carId = 1;

            for (int i = 0; i < 50; i++)
            {
                Manufacturer manufacturer = manufacturers[random.Next(manufacturers.Count)];
                cars.Add(new Car
                {
                    Id = carId++,
                    Model = $"{manufacturer.Name}-Model-{i}",
                    Price = Math.Round((decimal)(random.NextDouble() * 50000 + 10000), 2),
                    ManufactureYear = random.Next(1900, 2100),
                    Stock = random.Next(0, 1000),
                    ManufacturerId = manufacturer.Id
                });
            }

            modelBuilder.Entity<Car>().HasData(cars);
        }
    }
}
