using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{

    public class BookingList
    {
        public List<Booking> Bookings { get; set; }
    }


    public class Booking
    {
        public string ID { get; set; }
        public string BookingRef { get; set; }
        public string Surname { get; set; }
        public int  NoOfAdults { get; set; }
        public int  NoOfChildren { get; set; }
        public int TotalPax { get; set; }
        public int  ResortId { get; set; }
        public int  FlightID { get; set; }
        public int DestinationId { get; set; }
        public string BoardBasis { get; set; }
        public string Duration { get; set; }
    }
}
