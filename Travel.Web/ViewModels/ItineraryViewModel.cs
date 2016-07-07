using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel.Web.ViewModels
{
    public class ItineraryViewModel
    {
        public string DestinationName { get; set; }

        public string ArrivalName { get; set; }

        public string OutboundDepartureDatetime { get; set; }

        public string OutboundArrivalDateTime { get; set; }

        public string HotelName { get; set; }

        public string HotelDuration { get; set; }

        public string OutboundDuration { get; set; }

        public string InboundDuration { get; set; }

        public string BoardBasis { get; set; }

        public string InboundDepartureTime { get; set; }

        public string InboundArrivalTime { get; set; }

    }
}