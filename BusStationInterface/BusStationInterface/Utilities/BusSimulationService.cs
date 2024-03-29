﻿using BusStationInterface.Data;
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
        public event Action<string> OnUpdateStatus;
        public event Action<int> OnCurrentStopChanged;
        public int CurrentRouteDetailID { get; private set; }

        internal BusSimulationService(BusManagementContext context)
        {
            _context = context;
        }

        public void SimulateBusRoute(int scheduleId, CancellationToken cancellationToken)
        {
            // Fetch the schedule including related data
            var schedule = _context.Schedules
                .Include(s => s.Route)
                    .ThenInclude(r => r.RouteDetails)
                        .ThenInclude(rd => rd.Location) // Ensure Location is included
                .Include(s => s.Tickets)
                .FirstOrDefault(s => s.ScheduleID == scheduleId);

            if (schedule == null)
            {
                MessageBox.Show("Schedule not found.");
                return;
            }

            // Sort the route details by sequence number
            var sortedRouteDetails = schedule.Route.RouteDetails.OrderBy(rd => rd.SequenceNumber).ToList();

            foreach (var routeDetail in sortedRouteDetails)
            {
                cancellationToken.ThrowIfCancellationRequested();

                CurrentRouteDetailID = routeDetail.RouteDetailID;

                // Raise the event with the new current RouteDetailID
                 OnCurrentStopChanged?.Invoke(routeDetail.RouteDetailID);

                // Simulate arrival at each stop
                OnUpdateStatus.Invoke($"Arriving in {routeDetail.Location.Name}.");


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

                int timeToNextStopInMinutes = routeDetail.Time;
                    Thread.Sleep(timeToNextStopInMinutes * 100); 
                }

            Console.WriteLine("Route simulation complete.");
        }
    }
}