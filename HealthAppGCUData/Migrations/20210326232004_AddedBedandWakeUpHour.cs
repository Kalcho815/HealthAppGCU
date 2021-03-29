using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAppGCUData.Migrations
{
    public partial class AddedBedandWakeUpHour : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BED_HOUR",
                table: "HEALTHCARE_ACTIVITIES",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "WAKE_HOUR",
                table: "HEALTHCARE_ACTIVITIES",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BED_HOUR",
                table: "HEALTHCARE_ACTIVITIES");

            migrationBuilder.DropColumn(
                name: "WAKE_HOUR",
                table: "HEALTHCARE_ACTIVITIES");
        }
    }
}
