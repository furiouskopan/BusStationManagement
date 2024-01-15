 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class RouteDetailViewModel
    {
        public int RouteDetailID { get; set; }
        public int RouteID { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int SequenceNumber { get; set; }
        public int Time { get; set; }
        public string FormattedTime => $"{Time} minutes";
        public string Description { get; set; }
        public decimal PriceToNextStop { get; set; }
    }
}
