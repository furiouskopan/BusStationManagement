using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Route
    {
        public int RouteID { get; set; }
        public int StartDestinationID { get; set; }
        public int EndDestinationID { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public Destination StartDestination { get; set; }
        public Destination EndDestination { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<RouteDetail> RouteDetails { get; set; }
    }
}
