using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core;
using Travel.Core.DAL;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class ActivityController : Controller
    {
        // GET: Activities
        public ActionResult Index()
        {
            var datamanager = new DataManager();
            var activityViewModel = new ActivityViewModel();

            activityViewModel.Activities = Helper.GetActivites("alcudia", "2016-08-08", "2016-08-14").Activities.OrderBy(x => x.fromPrice).ToList();
            return View(activityViewModel);
        }
    }
}