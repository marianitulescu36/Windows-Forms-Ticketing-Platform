using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProiectPAW.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Servicii",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cazare = table.Column<string>(nullable: true),
                    Asigurari = table.Column<string>(nullable: true),
                    Transport = table.Column<string>(nullable: true),
                    Circuite = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servicii", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oferte",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ServiciuId = table.Column<int>(nullable: true),
                    Destinatie = table.Column<string>(nullable: true),
                    PunctPlecare = table.Column<string>(nullable: true),
                    DataCheckin = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oferte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Oferte_Servicii_ServiciuId",
                        column: x => x.ServiciuId,
                        principalTable: "Servicii",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Oferte_ServiciuId",
                table: "Oferte",
                column: "ServiciuId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Oferte");

            migrationBuilder.DropTable(
                name: "Servicii");
        }
    }
}
