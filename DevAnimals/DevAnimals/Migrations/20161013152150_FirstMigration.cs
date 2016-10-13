using System;
using System.Collections.Generic;
using Microsoft.Data.Entity.Migrations;

namespace DevAnimals.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    IdCategory = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PictureCategory = table.Column<byte[]>(nullable: true),
                    TypeCategory = table.Column<string>(nullable: true),
                    ZoneCategory = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_IdCategory", x => x.IdCategory);
                });
            migrationBuilder.CreateTable(
                name: "RegisterClass",
                columns: table => new
                {
                    IdUser = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    email = table.Column<string>(nullable: true),
                    location = table.Column<string>(nullable: true),
                    password = table.Column<string>(nullable: true),
                    telephoneNumber = table.Column<int>(nullable: false),
                    user = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryKey_IdUser", x => x.IdUser);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Category");
            migrationBuilder.DropTable("RegisterClass");
        }
    }
}