using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAppGCUData.Migrations
{
    public partial class AddedHoursSlept : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BLOOD_PRESSURE",
                table: "HEALTHCARE_ACTIVITIES");

            migrationBuilder.DropColumn(
                name: "NAME",
                table: "HEALTHCARE_ACTIVITIES");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "HOURS_SLEPT",
                table: "HEALTHCARE_ACTIVITIES",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HOURS_SLEPT",
                table: "HEALTHCARE_ACTIVITIES");

            migrationBuilder.AddColumn<int>(
                name: "BLOOD_PRESSURE",
                table: "HEALTHCARE_ACTIVITIES",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NAME",
                table: "HEALTHCARE_ACTIVITIES",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
