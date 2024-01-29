using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class TicketReportItem
    {
        public int TicketID { get; set; }
        public int BusID { get; set; }
        public DateTime IssueDate { get; set; }
        public string StartDestinationName { get; set; }
        public string EndDestinationName { get; set; }
        public decimal Price { get; set; }
        public string IssuedByEmployeeName { get; set; }
    }
}
