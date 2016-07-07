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
        public ActionResult Index(string bookingRef)
        {
            var viewModel = new ItineraryViewModel();
            var datamanager = new DataManager();
            // var bookingDetails = datamanager.GetBookingDetails(bookingRef);
            //var flights = datamanager.GetDestinationDetails(bookingDetails.De)
            return View();
        }
    }
}