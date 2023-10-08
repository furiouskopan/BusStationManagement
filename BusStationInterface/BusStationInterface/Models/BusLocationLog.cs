using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class BusLocationLog
    {
        public int LogID { get; set; }
        public int BusID { get; set; }
        public int DestinationID { get; set; } // Refers to the primary destination the bus departed from
        public int ScheduleID { get; set; }
        public DateTime? DepartureTime { get; set; }

        // Navigation Properties
        public Bus Bus { get; set; }
        public Destination Destination { get; set; }
        public Schedule Schedule { get; set; }
    }
}
