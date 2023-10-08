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

        // Navigation Properties
        public Bus Bus { get; set; }
        public Route Route { get; set; }
        public Driver Driver { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
