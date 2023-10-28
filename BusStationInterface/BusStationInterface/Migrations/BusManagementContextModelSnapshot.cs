﻿// <auto-generated />
using System;
using BusStationInterface.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BusStationInterface.Migrations
{
    [DbContext(typeof(BusManagementContext))]
    partial class BusManagementContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BusStationInterface.Models.Bus", b =>
                {
                    b.Property<int>("BusID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusID"));

                    b.Property<string>("BusType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("BusID");

                    b.ToTable("Buses");
                });

            modelBuilder.Entity("BusStationInterface.Models.BusLocationLog", b =>
                {
                    b.Property<int>("BusLocationLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BusLocationLogID"));

                    b.Property<int>("BusID")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DestinationID")
                        .HasColumnType("int");

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.HasKey("BusLocationLogID");

                    b.HasIndex("BusID");

                    b.HasIndex("DestinationID");

                    b.HasIndex("ScheduleID");

                    b.ToTable("BusLocationLogs");
                });

            modelBuilder.Entity("BusStationInterface.Models.Destination", b =>
                {
                    b.Property<int>("DestinationID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DestinationID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DestinationID");

                    b.ToTable("Destinations");
                });

            modelBuilder.Entity("BusStationInterface.Models.Driver", b =>
                {
                    b.Property<int>("DriverID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DriverID"));

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DriverID");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("BusStationInterface.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeID"));

                    b.Property<string>("ContactInformation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StationID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeID");

                    b.HasIndex("StationID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("BusStationInterface.Models.Route", b =>
                {
                    b.Property<int>("RouteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EndDestinationID")
                        .HasColumnType("int");

                    b.Property<int>("StartDestinationID")
                        .HasColumnType("int");

                    b.HasKey("RouteID");

                    b.HasIndex("EndDestinationID");

                    b.HasIndex("StartDestinationID");

                    b.ToTable("Routes");
                });

            modelBuilder.Entity("BusStationInterface.Models.RouteDetail", b =>
                {
                    b.Property<int>("RouteDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RouteDetailID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LocationID")
                        .HasColumnType("int");

                    b.Property<int>("RouteID")
                        .HasColumnType("int");

                    b.Property<int>("SequenceNumber")
                        .HasColumnType("int");

                    b.Property<TimeSpan>("Time")
                        .HasColumnType("time");

                    b.HasKey("RouteDetailID");

                    b.HasIndex("LocationID");

                    b.HasIndex("RouteID");

                    b.ToTable("RouteDetails");
                });

            modelBuilder.Entity("BusStationInterface.Models.Schedule", b =>
                {
                    b.Property<int>("ScheduleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ScheduleID"));

                    b.Property<int>("BusID")
                        .HasColumnType("int");

                    b.Property<int>("Day")
                        .HasColumnType("int");

                    b.Property<DateTime>("DepartureTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("DriverID")
                        .HasColumnType("int");

                    b.Property<int>("EndDestinationId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EstimatedArrivalTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("RouteID")
                        .HasColumnType("int");

                    b.Property<int>("StartDestinationId")
                        .HasColumnType("int");

                    b.HasKey("ScheduleID");

                    b.HasIndex("BusID");

                    b.HasIndex("DriverID");

                    b.HasIndex("EndDestinationId");

                    b.HasIndex("RouteID");

                    b.HasIndex("StartDestinationId");

                    b.ToTable("Schedules");
                });

            modelBuilder.Entity("BusStationInterface.Models.Seat", b =>
                {
                    b.Property<int>("SeatID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SeatID"));

                    b.Property<int>("BusID")
                        .HasColumnType("int");

                    b.Property<bool>("IsOccupied")
                        .HasColumnType("bit");

                    b.Property<string>("SeatNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeatID");

                    b.HasIndex("BusID");

                    b.ToTable("Seats");
                });

            modelBuilder.Entity("BusStationInterface.Models.Ticket", b =>
                {
                    b.Property<int>("TicketID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketID"));

                    b.Property<int>("ScheduleID")
                        .HasColumnType("int");

                    b.Property<int>("SeatID")
                        .HasColumnType("int");

                    b.HasKey("TicketID");

                    b.HasIndex("ScheduleID");

                    b.HasIndex("SeatID")
                        .IsUnique();

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("BusStationInterface.Models.TicketingLog", b =>
                {
                    b.Property<int>("TicketingLogID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TicketingLogID"));

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("TicketID")
                        .HasColumnType("int");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("datetime2");

                    b.HasKey("TicketingLogID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("TicketID")
                        .IsUnique();

                    b.ToTable("TicketingLogs");
                });

            modelBuilder.Entity("BusStationInterface.Models.BusLocationLog", b =>
                {
                    b.HasOne("BusStationInterface.Models.Bus", "Bus")
                        .WithMany("BusLocationLogs")
                        .HasForeignKey("BusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Destination", "Destination")
                        .WithMany("BusLocationLogs")
                        .HasForeignKey("DestinationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Schedule", "Schedule")
                        .WithMany()
                        .HasForeignKey("ScheduleID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Destination");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("BusStationInterface.Models.Employee", b =>
                {
                    b.HasOne("BusStationInterface.Models.Destination", "Station")
                        .WithMany()
                        .HasForeignKey("StationID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Station");
                });

            modelBuilder.Entity("BusStationInterface.Models.Route", b =>
                {
                    b.HasOne("BusStationInterface.Models.Destination", "EndDestination")
                        .WithMany()
                        .HasForeignKey("EndDestinationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Destination", "StartDestination")
                        .WithMany()
                        .HasForeignKey("StartDestinationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("EndDestination");

                    b.Navigation("StartDestination");
                });

            modelBuilder.Entity("BusStationInterface.Models.RouteDetail", b =>
                {
                    b.HasOne("BusStationInterface.Models.Destination", "Location")
                        .WithMany()
                        .HasForeignKey("LocationID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Route", "Route")
                        .WithMany("RouteDetails")
                        .HasForeignKey("RouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Location");

                    b.Navigation("Route");
                });

            modelBuilder.Entity("BusStationInterface.Models.Schedule", b =>
                {
                    b.HasOne("BusStationInterface.Models.Bus", "Bus")
                        .WithMany("Schedules")
                        .HasForeignKey("BusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Driver", "Driver")
                        .WithMany("Schedules")
                        .HasForeignKey("DriverID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Destination", "EndDestination")
                        .WithMany("EndSchedules")
                        .HasForeignKey("EndDestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Route", "Route")
                        .WithMany("Schedules")
                        .HasForeignKey("RouteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Destination", "StartDestination")
                        .WithMany("StartSchedules")
                        .HasForeignKey("StartDestinationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Bus");

                    b.Navigation("Driver");

                    b.Navigation("EndDestination");

                    b.Navigation("Route");

                    b.Navigation("StartDestination");
                });

            modelBuilder.Entity("BusStationInterface.Models.Seat", b =>
                {
                    b.HasOne("BusStationInterface.Models.Bus", "Bus")
                        .WithMany("Seats")
                        .HasForeignKey("BusID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bus");
                });

            modelBuilder.Entity("BusStationInterface.Models.Ticket", b =>
                {
                    b.HasOne("BusStationInterface.Models.Schedule", "Schedule")
                        .WithMany("Tickets")
                        .HasForeignKey("ScheduleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Seat", "Seat")
                        .WithOne("Ticket")
                        .HasForeignKey("BusStationInterface.Models.Ticket", "SeatID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Seat");
                });

            modelBuilder.Entity("BusStationInterface.Models.TicketingLog", b =>
                {
                    b.HasOne("BusStationInterface.Models.Employee", "Employee")
                        .WithMany("TicketingLogs")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BusStationInterface.Models.Ticket", "Ticket")
                        .WithOne("TicketingLog")
                        .HasForeignKey("BusStationInterface.Models.TicketingLog", "TicketID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Ticket");
                });

            modelBuilder.Entity("BusStationInterface.Models.Bus", b =>
                {
                    b.Navigation("BusLocationLogs");

                    b.Navigation("Schedules");

                    b.Navigation("Seats");
                });

            modelBuilder.Entity("BusStationInterface.Models.Destination", b =>
                {
                    b.Navigation("BusLocationLogs");

                    b.Navigation("EndSchedules");

                    b.Navigation("StartSchedules");
                });

            modelBuilder.Entity("BusStationInterface.Models.Driver", b =>
                {
                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("BusStationInterface.Models.Employee", b =>
                {
                    b.Navigation("TicketingLogs");
                });

            modelBuilder.Entity("BusStationInterface.Models.Route", b =>
                {
                    b.Navigation("RouteDetails");

                    b.Navigation("Schedules");
                });

            modelBuilder.Entity("BusStationInterface.Models.Schedule", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("BusStationInterface.Models.Seat", b =>
                {
                    b.Navigation("Ticket")
                        .IsRequired();
                });

            modelBuilder.Entity("BusStationInterface.Models.Ticket", b =>
                {
                    b.Navigation("TicketingLog")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
