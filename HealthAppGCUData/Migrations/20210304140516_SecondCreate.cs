using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthAppGCUData.Migrations
{
    public partial class SecondCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ACTIVITIES_DAILY_REPORTS");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ACTIVITIES_DAILY_REPORTS",
                columns: table => new
                {
                    HealthcareActivityId = table.Column<string>(type: "varchar(767)", nullable: false),
                    DailyReportId = table.Column<string>(type: "varchar(767)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ACTIVITIES_DAILY_REPORTS", x => new { x.HealthcareActivityId, x.DailyReportId });
                    table.ForeignKey(
                        name: "FK_ACTIVITIES_DAILY_REPORTS_DAILY_REPORTS_DailyReportId",
                        column: x => x.DailyReportId,
                        principalTable: "DAILY_REPORTS",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ACTIVITIES_DAILY_REPORTS_HEALTHCARE_ACTIVITIES_HealthcareAct~",
                        column: x => x.HealthcareActivityId,
                        principalTable: "HEALTHCARE_ACTIVITIES",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ACTIVITIES_DAILY_REPORTS_DailyReportId",
                table: "ACTIVITIES_DAILY_REPORTS",
                column: "DailyReportId");
        }
    }
}
