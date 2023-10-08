using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class TicketingLog
    {
        public int TicketingLogID { get; set; }
        public int EmployeeID { get; set; }
        public int TicketID { get; set; }
        public DateTime Timestamp { get; set; }

        // Navigation Properties
        public Employee Employee { get; set; }
        public Ticket Ticket { get; set; }
    }
}
