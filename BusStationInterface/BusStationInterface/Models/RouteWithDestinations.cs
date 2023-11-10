using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class RouteWithDestinations
    {
        public int RouteID { get; set; }
        public int StartDestinationId { get; set; }
        public int EndDestinationId { get; set; }
        public string StartDestination { get; set; }
        public string EndDestination { get; set; }
        public string Description { get; set; }
    }
}
