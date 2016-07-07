using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DAL;

namespace Travel.Web.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activities
        public ActionResult Index()
        {
            //var datamanager = new DataManager();
            //datamanager.(bookingRef);
            return View();
        }
    }
}