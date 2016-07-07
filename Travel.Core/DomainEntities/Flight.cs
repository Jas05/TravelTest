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
        public string InboundFlightDate { get; set; }
        public string InboundFlightTime { get; set; }
        public string InboundFlightDuration { get; set; }
        public string InboundFlightOperator { get; set; }
        public string InboundFlightCode { get; set; }
        public string OutboundFlightDate { get; set; }
        public string OutboundFlightTime { get; set; }
        public string OutboundFlightDuration { get; set; }
        public string OutboundFlightOperator { get; set; }
        public string OutboundFlightCode { get; set; }
        public string FlightFrom { get; set; }
        public string FlightTo { get; set; }
    }
}
