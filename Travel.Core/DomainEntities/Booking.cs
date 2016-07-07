using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{

    public class BookingList
    {
        public List<Booking> Booking { get; set; }

    }


    public class Booking
    {

        public int BookingId { get; set; }
        public string BookingRef { get; set; }
        public string Surname { get; set; }
    }
}
