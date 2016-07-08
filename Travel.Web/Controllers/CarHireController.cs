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
    public class CarHireController : Controller
    {
        // GET: CarHire
        public ActionResult Index()
        {
            var datamanager = new DataManager();
            var carHireViewModel = new CarHireViewModel();

            carHireViewModel.CarHire = Helper.GetCarHire("alcudia", "2016-08-08", "2016-08-14", "");
            return View(carHireViewModel);
        }
    }
}