using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStationInterface.Migrations
{
    /// <inheritdoc />
    public partial class ScheduleDay : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetails_Destinations_LocationID",
                table: "RouteDetails");

            migrationBuilder.AddColumn<int>(
                name: "Day",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetails_Destinations_LocationID",
                table: "RouteDetails",
                column: "LocationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RouteDetails_Destinations_LocationID",
                table: "RouteDetails");

            migrationBuilder.DropColumn(
                name: "Day",
                table: "Schedules");

            migrationBuilder.AddForeignKey(
                name: "FK_RouteDetails_Destinations_LocationID",
                table: "RouteDetails",
                column: "LocationID",
                principalTable: "Destinations",
                principalColumn: "DestinationID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
