using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusStationInterface.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Buses",
                columns: table => new
                {
                    BusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buses", x => x.BusID);
                });

            migrationBuilder.CreateTable(
                name: "Destinations",
                columns: table => new
                {
                    DestinationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destinations", x => x.DestinationID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    DriverID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.DriverID);
                });

            migrationBuilder.CreateTable(
                name: "Seats",
                columns: table => new
                {
                    SeatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusID = table.Column<int>(type: "int", nullable: false),
                    SeatNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsOccupied = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Seats", x => x.SeatID);
                    table.ForeignKey(
                        name: "FK_Seats_Buses_BusID",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "BusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactInformation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StationID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_Employees_Destinations_StationID",
                        column: x => x.StationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Routes",
                columns: table => new
                {
                    RouteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDestinationID = table.Column<int>(type: "int", nullable: false),
                    EndDestinationID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Routes", x => x.RouteID);
                    table.ForeignKey(
                        name: "FK_Routes_Destinations_EndDestinationID",
                        column: x => x.EndDestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Routes_Destinations_StartDestinationID",
                        column: x => x.StartDestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RouteDetails",
                columns: table => new
                {
                    RouteDetailID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RouteID = table.Column<int>(type: "int", nullable: false),
                    LocationID = table.Column<int>(type: "int", nullable: false),
                    SequenceNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RouteDetails", x => x.RouteDetailID);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Destinations_LocationID",
                        column: x => x.LocationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RouteDetails_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Schedules",
                columns: table => new
                {
                    ScheduleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusID = table.Column<int>(type: "int", nullable: false),
                    RouteID = table.Column<int>(type: "int", nullable: false),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EstimatedArrivalTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDestinationId = table.Column<int>(type: "int", nullable: false),
                    EndDestinationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schedules", x => x.ScheduleID);
                    table.ForeignKey(
                        name: "FK_Schedules_Buses_BusID",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "BusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Destinations_EndDestinationId",
                        column: x => x.EndDestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Destinations_StartDestinationId",
                        column: x => x.StartDestinationId,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Schedules_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "DriverID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Schedules_Routes_RouteID",
                        column: x => x.RouteID,
                        principalTable: "Routes",
                        principalColumn: "RouteID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BusLocationLogs",
                columns: table => new
                {
                    BusLocationLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BusID = table.Column<int>(type: "int", nullable: false),
                    DestinationID = table.Column<int>(type: "int", nullable: false),
                    ScheduleID = table.Column<int>(type: "int", nullable: false),
                    DepartureTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BusLocationLogs", x => x.BusLocationLogID);
                    table.ForeignKey(
                        name: "FK_BusLocationLogs_Buses_BusID",
                        column: x => x.BusID,
                        principalTable: "Buses",
                        principalColumn: "BusID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusLocationLogs_Destinations_DestinationID",
                        column: x => x.DestinationID,
                        principalTable: "Destinations",
                        principalColumn: "DestinationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BusLocationLogs_Schedules_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    TicketID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ScheduleID = table.Column<int>(type: "int", nullable: false),
                    SeatID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.TicketID);
                    table.ForeignKey(
                        name: "FK_Tickets_Schedules_ScheduleID",
                        column: x => x.ScheduleID,
                        principalTable: "Schedules",
                        principalColumn: "ScheduleID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Seats_SeatID",
                        column: x => x.SeatID,
                        principalTable: "Seats",
                        principalColumn: "SeatID");
                });

            migrationBuilder.CreateTable(
                name: "TicketingLogs",
                columns: table => new
                {
                    TicketingLogID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(type: "int", nullable: false),
                    TicketID = table.Column<int>(type: "int", nullable: false),
                    Timestamp = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TicketingLogs", x => x.TicketingLogID);
                    table.ForeignKey(
                        name: "FK_TicketingLogs_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TicketingLogs_Tickets_TicketID",
                        column: x => x.TicketID,
                        principalTable: "Tickets",
                        principalColumn: "TicketID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BusLocationLogs_BusID",
                table: "BusLocationLogs",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_BusLocationLogs_DestinationID",
                table: "BusLocationLogs",
                column: "DestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_BusLocationLogs_ScheduleID",
                table: "BusLocationLogs",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StationID",
                table: "Employees",
                column: "StationID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_LocationID",
                table: "RouteDetails",
                column: "LocationID");

            migrationBuilder.CreateIndex(
                name: "IX_RouteDetails_RouteID",
                table: "RouteDetails",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_EndDestinationID",
                table: "Routes",
                column: "EndDestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Routes_StartDestinationID",
                table: "Routes",
                column: "StartDestinationID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_BusID",
                table: "Schedules",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_DriverID",
                table: "Schedules",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_EndDestinationId",
                table: "Schedules",
                column: "EndDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_RouteID",
                table: "Schedules",
                column: "RouteID");

            migrationBuilder.CreateIndex(
                name: "IX_Schedules_StartDestinationId",
                table: "Schedules",
                column: "StartDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Seats_BusID",
                table: "Seats",
                column: "BusID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketingLogs_EmployeeID",
                table: "TicketingLogs",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TicketingLogs_TicketID",
                table: "TicketingLogs",
                column: "TicketID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ScheduleID",
                table: "Tickets",
                column: "ScheduleID");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_SeatID",
                table: "Tickets",
                column: "SeatID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BusLocationLogs");

            migrationBuilder.DropTable(
                name: "RouteDetails");

            migrationBuilder.DropTable(
                name: "TicketingLogs");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Schedules");

            migrationBuilder.DropTable(
                name: "Seats");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Routes");

            migrationBuilder.DropTable(
                name: "Buses");

            migrationBuilder.DropTable(
                name: "Destinations");
        }
    }
}
