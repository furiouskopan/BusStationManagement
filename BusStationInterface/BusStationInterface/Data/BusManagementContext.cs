using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore; 

namespace BusStationInterface.Data 
{
    public class BusManagementContext : DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusLocationLog> BusLocationLogs { get; set; }
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<RouteDetail> RouteDetails { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketingLog> TicketingLogs { get; set; }
        public DbSet<TicketReportItem> TicketReportItem { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuration for Schedule -> Destination relationships
            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.StartDestination)
                .WithMany(d => d.StartSchedules)
                .HasForeignKey(s => s.StartDestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Schedule>()
                .HasOne(s => s.EndDestination)
                .WithMany(d => d.EndSchedules)
                .HasForeignKey(s => s.EndDestinationId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Route>()
                .HasOne(r => r.StartDestination)
                .WithMany()
                .HasForeignKey(r => r.StartDestinationID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RouteDetail>()
                .HasOne(rd => rd.Location)
                .WithMany()
                .HasForeignKey(rd => rd.LocationID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Route>()
                .HasOne(r => r.EndDestination)
                .WithMany()
                .HasForeignKey(r => r.EndDestinationID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<BusLocationLog>()
                .HasOne(log => log.Schedule)
                .WithMany()
                .HasForeignKey(log => log.ScheduleID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Seat)
                .WithOne(s => s.Ticket)
                .HasForeignKey<Ticket>(t => t.SeatID)
                .IsRequired(true);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.StartRouteDetail)
                .WithMany()
                .HasForeignKey(t => t.StartRouteDetailID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.EndRouteDetail)
                .WithMany()
                .HasForeignKey(t => t.EndRouteDetailID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Seat>()
                .HasOne(s => s.Ticket)
                .WithOne(t => t.Seat)
                .HasForeignKey<Ticket>(t => t.SeatID)
                .IsRequired(true);

            // Configure the Tickets -> Seats relationship with DeleteBehavior.NoAction
            modelBuilder.Entity<Ticket>()
                .HasOne(t => t.Seat)
                .WithOne(s => s.Ticket)
                .HasForeignKey<Ticket>(t => t.SeatID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<RouteDetail>()
                .Property(rd => rd.PriceToNextStop)
                .HasColumnType("decimal(10, 0)"); // Sets the precision to 10 and scale to 0

            // Configure decimal precision for Price in Ticket
            modelBuilder.Entity<Ticket>()
                .Property(t => t.Price)
                .HasColumnType("decimal(10, 0)");

            modelBuilder.Entity<TicketReportItem>().HasNoKey();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-S5ULU19\\SQLEXPRESS;Initial Catalog=BusStation;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            }
        }
    }
}
