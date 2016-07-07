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
        public string InboundDepartureFlightDate { get; set; }
        public string InboundDepartureFlightTime { get; set; }

        public string InboundArrivalFlightDate { get; set; }

        public string InboundArrivalFlightTime { get; set; }

        public string InboundFlightDuration { get; set; }
        public string InboundFlightOperator { get; set; }
        public string InboundFlightCode { get; set; }
        public string OutboundDepartureFlightDate { get; set; }
        public string OutboundDepartureFlightTime { get; set; }
        public string OutboundArrivalFlightDate { get; set; }
        public string OutboundArrivalFlightTime { get; set; }
        public string OutboundFlightDuration { get; set; }
        public string OutboundFlightOperator { get; set; }
        public string OutboundFlightCode { get; set; }
        public string FlightFrom { get; set; }
        public string FlightTo { get; set; }
    }
}
