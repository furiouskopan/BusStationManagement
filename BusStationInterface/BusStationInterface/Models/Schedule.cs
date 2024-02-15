using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Schedule
    {
        public int ScheduleID { get; set; }
        public int BusID { get; set; }
        public int RouteID { get; set; }
        public int DriverID { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime EstimatedArrivalTime { get; set; }
        public DayOfWeek Day { get; set; }
        public string Status { get; set; }
        public int StartDestinationId { get; set; } // Foreign Key
        public int EndDestinationId { get; set; }   // Foreign Key
        public DateTime NextOccurrenceDate { get; set; } // The next date when the schedule will be active

        // Navigation Properties
        public Destination StartDestination { get; set; } 
        public Destination EndDestination { get; set; }  
        public Bus Bus { get; set; }
        public Route Route { get; set; }
        public Driver Driver { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}