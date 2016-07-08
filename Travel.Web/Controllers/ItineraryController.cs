using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DAL;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class ItineraryController : Controller
    {
        // GET: Itinerary
        public ActionResult Index()
        {
            var bookingRef = HttpContext.Session["BookingRef"] != null ? HttpContext.Session["BookingRef"].ToString() : "123456";
            var viewModel = new ItineraryViewModel();
            var datamanager = new DataManager();
            var bookingDetails = datamanager.GetBookingDetails(bookingRef);
            var destinationDetails = datamanager.GetDestinationDetails(bookingDetails.DestinationId.ToString());
            var flights = datamanager.GetFlightDetails(bookingDetails.DestinationId.ToString());
            var resorts = datamanager.GetResortDetails(bookingDetails.ResortId.ToString());

            viewModel.ArrivalName = flights.FlightTo;
            viewModel.DestinationName = flights.FlightFrom;
            viewModel.OutboundDepartureDatetime = flights.OutboundDepartureFlightDate + " " + flights.OutboundDepartureFlightTime;
            viewModel.OutboundArrivalDateTime = flights.OutboundArrivalFlightDate +" "+ flights.OutboundArrivalFlightTime;
            viewModel.InboundDepartureTime = flights.InboundDepartureFlightDate + " " + flights.InboundDepartureFlightTime;
            viewModel.InboundArrivalTime = flights.InboundArrivalFlightDate + " " + flights.InboundArrivalFlightTime;
            viewModel.OutboundDuration = flights.OutboundFlightDuration;
            viewModel.InboundDuration = flights.InboundFlightDuration;
            viewModel.BoardBasis = bookingDetails.BoardBasis;
            viewModel.HotelName = resorts.ResortName;
            viewModel.HotelDuration = bookingDetails.Duration;
            return View(viewModel);
        }
    }
}