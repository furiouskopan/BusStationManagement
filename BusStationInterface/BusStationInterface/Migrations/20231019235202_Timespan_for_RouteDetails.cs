using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStationInterface.Migrations
{
    /// <inheritdoc />
    public partial class Timespan_for_RouteDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "RouteDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Time",
                table: "RouteDetails",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "RouteDetails");

            migrationBuilder.DropColumn(
                name: "Time",
                table: "RouteDetails");
        }
    }
}
