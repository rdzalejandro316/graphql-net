using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FooBar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("0ed75dac-9949-4e7a-9f00-e771c8168324"));

            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("fffe8346-47be-48b1-8a8f-9f4ce9dcbf10"));

            migrationBuilder.InsertData(
                table: "Voter",
                columns: new[] { "Id", "DateOfBirth", "Nid", "Origin" },
                values: new object[,]
                {
                    { new Guid("66c7678d-7741-40ad-bc37-597abbcfcaa6"), new DateTime(2024, 8, 8, 19, 48, 26, 164, DateTimeKind.Local).AddTicks(1175), "1033796537", "Colombia" },
                    { new Guid("b0cbb9b3-8342-487b-bd99-2d71fb9d150b"), new DateTime(2024, 8, 8, 19, 48, 26, 164, DateTimeKind.Local).AddTicks(1306), "1033796537", "Peru" },
                    { new Guid("f2cc58c7-fdad-4957-b507-27fc585a05ca"), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "79254420", "COLOMBIA" },
                    { new Guid("fe037753-d3e1-4f4a-a2ed-470c3841aa15"), new DateTime(2024, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "51765132", "COLOMBIA" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("66c7678d-7741-40ad-bc37-597abbcfcaa6"));

            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("b0cbb9b3-8342-487b-bd99-2d71fb9d150b"));

            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("f2cc58c7-fdad-4957-b507-27fc585a05ca"));

            migrationBuilder.DeleteData(
                table: "Voter",
                keyColumn: "Id",
                keyValue: new Guid("fe037753-d3e1-4f4a-a2ed-470c3841aa15"));

            migrationBuilder.InsertData(
                table: "Voter",
                columns: new[] { "Id", "DateOfBirth", "Nid", "Origin" },
                values: new object[,]
                {
                    { new Guid("0ed75dac-9949-4e7a-9f00-e771c8168324"), new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6423), "1033796537", "Colombia" },
                    { new Guid("fffe8346-47be-48b1-8a8f-9f4ce9dcbf10"), new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6469), "1033796537", "Peru" }
                });
        }
    }
}
