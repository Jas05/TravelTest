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
    }
}
