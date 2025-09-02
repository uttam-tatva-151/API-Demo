using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "Id", "Country", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, "Japan", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4600), "Toyota" },
                    { 2, "Germany", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4614), "BMW" },
                    { 3, "USA", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4616), "Ford" },
                    { 4, "Japan", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4618), "Honda" },
                    { 5, "South Korea", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4620), "Hyundai" },
                    { 6, "India", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4621), "Tata Motors" },
                    { 7, "India", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4622), "Mahindra" },
                    { 8, "India", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4624), "Maruti Suzuki" },
                    { 9, "Russia", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4625), "AvtoVAZ (Lada)" },
                    { 10, "Russia", new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4627), "GAZ" }
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CreatedAt", "ManufactureYear", "ManufacturerId", "Model", "Price", "Stock" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4740), 2094, 3, "Ford-Model-0", 28410.92m, 69 },
                    { 2, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4792), 2081, 8, "Maruti Suzuki-Model-1", 47236.16m, 649 },
                    { 3, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4797), 1908, 5, "Hyundai-Model-2", 22300.07m, 149 },
                    { 4, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4802), 2087, 8, "Maruti Suzuki-Model-3", 17010.07m, 325 },
                    { 5, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4805), 1907, 4, "Honda-Model-4", 53545.48m, 786 },
                    { 6, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4810), 1975, 5, "Hyundai-Model-5", 17747.84m, 524 },
                    { 7, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4813), 2075, 8, "Maruti Suzuki-Model-6", 59348.23m, 557 },
                    { 8, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4816), 2072, 3, "Ford-Model-7", 11924.95m, 327 },
                    { 9, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4819), 2090, 1, "Toyota-Model-8", 11841.12m, 426 },
                    { 10, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4824), 1990, 8, "Maruti Suzuki-Model-9", 36001.98m, 154 },
                    { 11, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4827), 1947, 5, "Hyundai-Model-10", 58930.18m, 25 },
                    { 12, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4833), 1958, 9, "AvtoVAZ (Lada)-Model-11", 24385.79m, 243 },
                    { 13, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4837), 1964, 8, "Maruti Suzuki-Model-12", 49049.32m, 565 },
                    { 14, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4840), 2087, 4, "Honda-Model-13", 36592.93m, 618 },
                    { 15, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4842), 1983, 10, "GAZ-Model-14", 59831.21m, 699 },
                    { 16, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4845), 2091, 8, "Maruti Suzuki-Model-15", 21294.76m, 702 },
                    { 17, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4848), 2068, 3, "Ford-Model-16", 50561.68m, 340 },
                    { 18, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4853), 1928, 10, "GAZ-Model-17", 54131.31m, 416 },
                    { 19, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4856), 2094, 5, "Hyundai-Model-18", 11074.29m, 235 },
                    { 20, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4858), 2079, 6, "Tata Motors-Model-19", 59419.44m, 485 },
                    { 21, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4862), 1962, 3, "Ford-Model-20", 58230.88m, 905 },
                    { 22, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4864), 1915, 5, "Hyundai-Model-21", 21618.40m, 279 },
                    { 23, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4867), 1910, 7, "Mahindra-Model-22", 39287.95m, 338 },
                    { 24, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4870), 2044, 5, "Hyundai-Model-23", 13401.25m, 463 },
                    { 25, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4873), 1920, 7, "Mahindra-Model-24", 57433.17m, 556 },
                    { 26, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4875), 1957, 5, "Hyundai-Model-25", 33066.12m, 601 },
                    { 27, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4878), 2049, 8, "Maruti Suzuki-Model-26", 55806.45m, 750 },
                    { 28, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4880), 2005, 7, "Mahindra-Model-27", 50777.99m, 116 },
                    { 29, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4883), 1933, 5, "Hyundai-Model-28", 15303.64m, 590 },
                    { 30, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4885), 1984, 1, "Toyota-Model-29", 55350.97m, 982 },
                    { 31, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4888), 2022, 10, "GAZ-Model-30", 11693.56m, 519 },
                    { 32, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4891), 2059, 8, "Maruti Suzuki-Model-31", 37935.43m, 545 },
                    { 33, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4894), 1968, 6, "Tata Motors-Model-32", 38912.37m, 322 },
                    { 34, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4940), 2050, 5, "Hyundai-Model-33", 33230.07m, 679 },
                    { 35, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4944), 1928, 3, "Ford-Model-34", 19078.32m, 240 },
                    { 36, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4946), 2037, 10, "GAZ-Model-35", 57581.07m, 855 },
                    { 37, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4949), 2098, 2, "BMW-Model-36", 53591.82m, 183 },
                    { 38, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4952), 1984, 7, "Mahindra-Model-37", 13029.82m, 41 },
                    { 39, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4955), 1945, 4, "Honda-Model-38", 45782.15m, 898 },
                    { 40, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4957), 2069, 6, "Tata Motors-Model-39", 19604.71m, 531 },
                    { 41, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4960), 1929, 1, "Toyota-Model-40", 40271.30m, 770 },
                    { 42, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4963), 2049, 2, "BMW-Model-41", 14863.72m, 647 },
                    { 43, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4965), 2059, 10, "GAZ-Model-42", 46765.88m, 916 },
                    { 44, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4968), 1995, 4, "Honda-Model-43", 27131.97m, 361 },
                    { 45, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4970), 2041, 5, "Hyundai-Model-44", 19490.16m, 599 },
                    { 46, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4974), 1951, 3, "Ford-Model-45", 44810.73m, 503 },
                    { 47, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4976), 2042, 5, "Hyundai-Model-46", 22661.54m, 421 },
                    { 48, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4978), 1920, 8, "Maruti Suzuki-Model-47", 32614.16m, 396 },
                    { 49, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4981), 1931, 4, "Honda-Model-48", 20271.05m, 785 },
                    { 50, new DateTime(2025, 9, 2, 17, 20, 36, 299, DateTimeKind.Local).AddTicks(4985), 1930, 4, "Honda-Model-49", 48357.55m, 259 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "Id",
                keyValue: 10);
        }
    }
}
