using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AnimalShelterApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Animals",
                columns: table => new
                {
                    AnimalId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Species = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(250)", maxLength: 250, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Age = table.Column<int>(type: "int", nullable: false),
                    DateAdded = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animals", x => x.AnimalId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Animals",
                columns: new[] { "AnimalId", "Age", "DateAdded", "Description", "Name", "Species" },
                values: new object[,]
                {
                    { 1, 5, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(7970), "Black and white cat", "Izze", "Cat" },
                    { 2, 12, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8020), "Small dog with black, brown, and orange fur.", "Kobe", "Dog" },
                    { 3, 10, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8020), "Medium dog with black, brown,orange, and white fur.", "Shadow", "Dog" },
                    { 4, 14, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8020), "Small black and white dog.", "AJ", "Dog" },
                    { 5, 10, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8030), "Grey tabbey.", "Bella", "Cat" },
                    { 6, 8, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8030), "Ginger and white cat.", "Ziggy", "Cat" },
                    { 7, 6, new DateTime(2023, 2, 10, 20, 9, 7, 226, DateTimeKind.Local).AddTicks(8030), "Grey with black stripes.", "Marley", "Cat" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animals");
        }
    }
}
