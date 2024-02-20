using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusStationInterface.Models
{
    public class Seat
    {
        public int SeatID { get; set; }
        public int BusID { get; set; }
        public string SeatNumber { get; set; }
        public bool IsOccupied { get; set; }

        // Navigation Properties
        public Bus Bus { get; set; }
        public ICollection<Ticket> Tickets { get; set; }
    }
}
