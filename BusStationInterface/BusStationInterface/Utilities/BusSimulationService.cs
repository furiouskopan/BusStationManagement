using BusStationInterface.Data;
using BusStationInterface.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace BusStationInterface.Utilities
{
    public class BusSimulationService
    {
        private readonly BusManagementContext _context;
        private readonly Action<string> _updateStatusAction;

        internal BusSimulationService(BusManagementContext context, Action<string> updateStatusAction)
        {
            _context = context;
            _updateStatusAction = updateStatusAction;
        }

        public void SimulateBusRoute(int scheduleId)
        {
            // Fetch the schedule including related data
            var schedule = _context.Schedules
                .Include(s => s.Route)
                    .ThenInclude(r => r.RouteDetails)
                .Include(s => s.Tickets)
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null)
            {
                Console.WriteLine("Schedule not found.");
                return;
            }

            // Sort the route details by sequence number
            var sortedRouteDetails = schedule.Route.RouteDetails.OrderBy(rd => rd.SequenceNumber).ToList();

            foreach (var routeDetail in sortedRouteDetails)
            {
                // Simulate arrival at each stop
                Console.WriteLine($"Arriving at {routeDetail.Location.Name}.");

                // Find tickets where this stop is the end destination
                var ticketsToEndHere = schedule.Tickets
                    .Where(t => t.EndRouteDetailID == routeDetail.RouteDetailID).ToList();

                foreach (var ticket in ticketsToEndHere)
                {
                    // Mark the seat as unoccupied
                    var seat = _context.Seats.FirstOrDefault(s => s.SeatID == ticket.SeatID);
                    if (seat != null)
                    {
                        seat.IsOccupied = false;
                    }
                }

                // Save changes to the database
                _context.SaveChanges();

                // Simulate time spent until reaching the next stop
                // For simplicity, we'll just use a delay here, but in a real application,
                // you might have more complex logic or real-time integration
                int timeToNextStopInMinutes = routeDetail.Time; // Assuming 'Time' is now an int representing minutes
                Thread.Sleep(timeToNextStopInMinutes * 1000); // Convert minutes to milliseconds
            }

            Console.WriteLine("Route simulation complete.");
        }
    }
}
