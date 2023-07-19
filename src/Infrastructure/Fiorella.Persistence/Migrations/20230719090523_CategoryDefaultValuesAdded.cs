using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Fiorella.Persistence.Migrations
{
    public partial class CategoryDefaultValuesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("0951eb2a-061a-4279-aee7-722bd5ccdfac"), null, "Plants" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("8ea7e2f1-5736-4c61-99ec-f00dd220d062"), null, "Cactus" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { new Guid("e883a452-c972-4fff-8fdb-f4c38f495df7"), null, "Flowers" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("0951eb2a-061a-4279-aee7-722bd5ccdfac"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("8ea7e2f1-5736-4c61-99ec-f00dd220d062"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: new Guid("e883a452-c972-4fff-8fdb-f4c38f495df7"));
        }
    }
}
