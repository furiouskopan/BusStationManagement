using BusStationInterface.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Utilities
{
    public class ScheduleService
    {
        private readonly BusManagementContext _context;

        public ScheduleService(BusManagementContext context)
        {
            _context = context;
        }

        public void UpdateScheduleDatesForNextWeek()
        {
            var today = DateTime.Today;
            var schedulesToUpdate = _context.Schedules
                                            .Where(s => s.NextOccurrenceDate <= today)
                                            .ToList();

            foreach (var schedule in schedulesToUpdate)
            {
                var daysToAdd = ((int)schedule.Day - (int)today.DayOfWeek + 7) % 7;
                if (daysToAdd == 0) daysToAdd = 7; // If it's the same day, schedule for the next week.
                schedule.NextOccurrenceDate = today.AddDays(daysToAdd);
            }

            _context.SaveChanges();
        }
    }
}
