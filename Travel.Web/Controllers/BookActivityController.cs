using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DomainEntities;

namespace Travel.Web.Controllers
{
    public class BookActivityController : Controller
    {
        // GET: BookActivity
        public ActionResult Index(Activity2 Activity)
        {
            return View(Activity);
        }
    }
}