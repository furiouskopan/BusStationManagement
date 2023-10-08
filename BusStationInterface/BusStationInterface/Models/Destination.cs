using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Destination
    {
        public int DestinationID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        // Navigation Properties
        public ICollection<Schedule> StartSchedules { get; set; }
        public ICollection<Schedule> EndSchedules { get; set; }
        public ICollection<BusLocationLog> BusLocationLogs { get; set; }
    }
}
