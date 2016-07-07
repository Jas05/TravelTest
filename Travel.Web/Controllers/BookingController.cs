using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel.Web.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        public ActionResult Index()
        {
            return View();
        }

        public bool ValidateUser(string bookingRef, string surname)
        {
            if(bookingRef == "123456" && surname == "spectrum")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}