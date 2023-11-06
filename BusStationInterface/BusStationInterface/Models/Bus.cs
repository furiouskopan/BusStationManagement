    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Bus
    {
        public int BusID { get; set; }
        public string BusType { get; set; }
        public int TotalSeats { get; set; }

        // Navigation Properties
        public ICollection<Seat> Seats { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<BusLocationLog> BusLocationLogs { get; set; }
    }
}
