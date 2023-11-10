using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStationInterface.Migrations
{
    /// <inheritdoc />
    public partial class PriceToNextStop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets");

            migrationBuilder.AddColumn<int>(
                name: "EndRouteDetailID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Tickets",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "StartRouteDetailID",
                table: "Tickets",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceToNextStop",
                table: "RouteDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_EndRouteDetailID",
                table: "Tickets",
                column: "EndRouteDetailID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_StartRouteDetailID",
                table: "Tickets",
                column: "StartRouteDetailID");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_RouteDetails_EndRouteDetailID",
                table: "Tickets",
                column: "EndRouteDetailID",
                principalTable: "RouteDetails",
                principalColumn: "RouteDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_RouteDetails_StartRouteDetailID",
                table: "Tickets",
                column: "StartRouteDetailID",
                principalTable: "RouteDetails",
                principalColumn: "RouteDetailID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets",
                column: "SeatID",
                principalTable: "Seats",
                principalColumn: "SeatID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_RouteDetails_EndRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_RouteDetails_StartRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_EndRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropIndex(
                name: "IX_Tickets_StartRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "EndRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "StartRouteDetailID",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "PriceToNextStop",
                table: "RouteDetails");

            migrationBuilder.AddForeignKey(
                name: "FK_Tickets_Seats_SeatID",
                table: "Tickets",
                column: "SeatID",
                principalTable: "Seats",
                principalColumn: "SeatID");
        }
    }
}
