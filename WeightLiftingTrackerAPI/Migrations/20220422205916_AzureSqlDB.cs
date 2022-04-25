using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrackerAPI.Migrations
{
    public partial class AzureSqlDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 1,
                column: "Date",
                value: "22/04/2022");

            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 2,
                column: "Date",
                value: "22/04/2022");

            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 3,
                column: "Date",
                value: "22/04/2022");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 1,
                column: "Date",
                value: "25/03/2022");

            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 2,
                column: "Date",
                value: "25/03/2022");

            migrationBuilder.UpdateData(
                table: "LiftingStats",
                keyColumn: "LiftingStatId",
                keyValue: 3,
                column: "Date",
                value: "25/03/2022");
        }
    }
}
