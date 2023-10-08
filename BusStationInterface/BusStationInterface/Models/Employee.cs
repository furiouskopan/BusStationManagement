using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }
        public int StationID { get; set; }

        // Navigation Properties
        public Destination Station { get; set; }
        public ICollection<TicketingLog> TicketingLogs { get; set; }
    }
}
