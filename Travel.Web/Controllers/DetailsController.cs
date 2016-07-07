using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DAL;

namespace Travel.Web.Controllers
{
    public class DetailsController : Controller
    {
        // GET: Details
        public ActionResult Index(string bookingRef)
        {
            var datamanager = new DataManager();
            datamanager.GetBookingDetails(bookingRef);

            return View();
        }
    }
}