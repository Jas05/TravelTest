using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DAL;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index(string bookingRef)
        {
            var datamanager = new DataManager();
            var data = datamanager.GetBookingDetails(bookingRef);
            var viewModel = new DetailsViewModel();
            viewModel.BookingRef = data.BookingRef;
            viewModel.DestinationId = data.DestinationId.ToString();
            viewModel.BookingId = data.ID;
                
            return View(viewModel);
        }
    }
}