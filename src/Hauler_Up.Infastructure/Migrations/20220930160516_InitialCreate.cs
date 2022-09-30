using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hauler_Up.Infastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trawl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trawl", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Catch",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Market = table.Column<int>(type: "int", nullable: false),
                    Canner = table.Column<int>(type: "int", nullable: false),
                    TrawlId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catch", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Catch_Trawl_TrawlId",
                        column: x => x.TrawlId,
                        principalTable: "Trawl",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Catch_TrawlId",
                table: "Catch",
                column: "TrawlId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Catch");

            migrationBuilder.DropTable(
                name: "Trawl");
        }
    }
}
