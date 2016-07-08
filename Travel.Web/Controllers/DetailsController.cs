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
        public ActionResult Index()
        {
            var bookingRef = HttpContext.Session["BookingRef"] == null ? HttpContext.Session["BookingRef"].ToString() : "123456";
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