using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animals.Data.Migrations
{
    public partial class FoodTableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(maxLength: 50, nullable: false),
                    FoodType = table.Column<string>(maxLength: 50, nullable: false),
                    Nutrients = table.Column<string>(maxLength: 50, nullable: false),
                    AllergiesIngredients = table.Column<string>(maxLength: 50, nullable: false),
                    ExpiryDate = table.Column<DateTime>(nullable: false),
                    AnimalID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Food_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "AnimalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_AnimalID",
                table: "Food",
                column: "AnimalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Food");
        }
    }
}
