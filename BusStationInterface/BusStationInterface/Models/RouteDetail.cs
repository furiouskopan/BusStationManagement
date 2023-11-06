using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class RouteDetail
    {
        public int RouteDetailID { get; set; }
        public int RouteID { get; set; }
        public int LocationID { get; set; } 
        public int SequenceNumber { get; set; }
        public TimeSpan Time { get; set; } 
        public string? Description { get; set; }
        public decimal PriceToNextStop { get; set; }

        // Navigation Properties
        public Route Route { get; set; }
        public Destination Location { get; set; }
    }
}
