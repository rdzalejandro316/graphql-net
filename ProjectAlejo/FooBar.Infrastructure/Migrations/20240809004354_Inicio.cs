using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FooBar.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Inicio : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Voter",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Voter", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Voter",
                columns: new[] { "Id", "DateOfBirth", "Nid", "Origin" },
                values: new object[,]
                {
                    { new Guid("0ed75dac-9949-4e7a-9f00-e771c8168324"), new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6423), "1033796537", "Colombia" },
                    { new Guid("fffe8346-47be-48b1-8a8f-9f4ce9dcbf10"), new DateTime(2024, 8, 8, 19, 43, 54, 442, DateTimeKind.Local).AddTicks(6469), "1033796537", "Peru" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Voter");
        }
    }
}
