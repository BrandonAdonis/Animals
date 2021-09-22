using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Animals.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    AnimalID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(maxLength: 50, nullable: false),
                    Habitat = table.Column<string>(maxLength: 50, nullable: false),
                    Category = table.Column<string>(maxLength: 50, nullable: false),
                    AgeOfAnimal = table.Column<string>(maxLength: 50, nullable: false),
                    DateRegistered = table.Column<DateTime>(nullable: false),
                    FeedingTime = table.Column<DateTime>(nullable: false),
                    AnimalCheckup = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.AnimalID);
                });

            migrationBuilder.CreateTable(
                name: "StaffMember",
                columns: table => new
                {
                    StaffMemberID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: false),
                    EnclosureWorkingAt = table.Column<string>(maxLength: 50, nullable: false),
                    Sex = table.Column<string>(nullable: false),
                    Roles = table.Column<string>(maxLength: 50, nullable: false),
                    DateEmployed = table.Column<DateTime>(nullable: false),
                    PhoneNum = table.Column<int>(nullable: false),
                    AnimalID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StaffMember", x => x.StaffMemberID);
                    table.ForeignKey(
                        name: "FK_StaffMember_Animal_AnimalID",
                        column: x => x.AnimalID,
                        principalTable: "Animal",
                        principalColumn: "AnimalID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StaffMember_AnimalID",
                table: "StaffMember",
                column: "AnimalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StaffMember");

            migrationBuilder.DropTable(
                name: "Animal");
        }
    }
}
