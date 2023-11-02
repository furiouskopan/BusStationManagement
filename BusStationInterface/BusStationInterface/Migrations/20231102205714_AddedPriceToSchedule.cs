using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStationInterface.Migrations
{
    /// <inheritdoc />
    public partial class AddedPriceToSchedule : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Price",
                table: "Schedules",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Schedules");
        }
    }
}
