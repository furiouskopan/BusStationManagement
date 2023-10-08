using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Driver
    {
        public int DriverID { get; set; }
        public string Name { get; set; }
        public string ContactInformation { get; set; }

        // Navigation Property
        public ICollection<Schedule> Schedules { get; set; }
    }
}
