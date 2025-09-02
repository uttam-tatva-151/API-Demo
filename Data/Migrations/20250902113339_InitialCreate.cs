using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key. Auto-incremented.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Name of the manufacturer (e.g., Toyota, BMW)."),
                    Country = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Country where the manufacturer is based."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "Timestamp when the manufacturer was created.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("manufacturers_pkey", x => x.Id);
                },
                comment: "Stores car manufacturer information.");

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false, comment: "Primary Key. Auto-incremented.")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Model = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false, comment: "Car model name (e.g., Corolla, X5)."),
                    Price = table.Column<decimal>(type: "numeric(18,2)", nullable: false, comment: "Price of the car."),
                    ManufactureYear = table.Column<int>(type: "integer", nullable: false, comment: "Year the car was manufactured."),
                    Stock = table.Column<int>(type: "integer", nullable: false, defaultValue: 0, comment: "Number of cars available in stock."),
                    CreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false, defaultValueSql: "now()", comment: "Timestamp when the car was created."),
                    ManufacturerId = table.Column<int>(type: "integer", nullable: false, comment: "FK referencing the Manufacturer of this car.")
                },
                constraints: table =>
                {
                    table.PrimaryKey("cars_pkey", x => x.Id);
                    table.ForeignKey(
                        name: "cars_manufacturerid_fkey",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Stores information about cars.");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ManufacturerId",
                table: "Cars",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_Name",
                table: "Manufacturers",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Manufacturers");
        }
    }
}
