using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Ticket
    {
        public int TicketID { get; set; }
        public int ScheduleID { get; set; }
        public int? SeatID { get; set; }
        public int StartRouteDetailID { get; set; }
        public int EndRouteDetailID { get; set; }
        public decimal Price { get; set; }

        // Navigation Properties
        public Schedule Schedule { get; set; }
        public Seat Seat { get; set; }
        public TicketingLog TicketingLog { get; set; }
        public RouteDetail StartRouteDetail { get; set; }
        public RouteDetail EndRouteDetail { get; set; }
    }
}
