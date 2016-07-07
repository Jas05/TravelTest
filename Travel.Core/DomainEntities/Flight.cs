using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travel.Core.DomainEntities
{
    public class FlightList
    {
        public List<Flight> Flights { get; set; }
    }

    public class Flight
    {
        public string ID { get; set; }
    }
}
