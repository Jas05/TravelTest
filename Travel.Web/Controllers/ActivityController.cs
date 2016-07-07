using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
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

            activityViewModel.Activities = datamanager.GetAllActivities();
            return View(activityViewModel);
        }
    }
}