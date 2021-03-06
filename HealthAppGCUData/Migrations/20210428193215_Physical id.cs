using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAppGCUData.Migrations
{
    public partial class Physicalid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PHYSICAL_ACTIVITIES",
                columns: table => new
                {
                    ID = table.Column<string>(maxLength: 255, nullable: false),
                    NAME = table.Column<string>(maxLength: 255, nullable: true),
                    USER_ID = table.Column<string>(nullable: true),
                    DATE = table.Column<DateTime>(nullable: false),
                    TIME_STARTED = table.Column<DateTime>(nullable: false),
                    TIME_ENDED = table.Column<DateTime>(nullable: false),
                    DISTANCE_COVERED = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PHYSICAL_ACTIVITIES", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PHYSICAL_ACTIVITIES_AspNetUsers_USER_ID",
                        column: x => x.USER_ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PHYSICAL_ACTIVITIES_USER_ID",
                table: "PHYSICAL_ACTIVITIES",
                column: "USER_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PHYSICAL_ACTIVITIES");
        }
    }
}
