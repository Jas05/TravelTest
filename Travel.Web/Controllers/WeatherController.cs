using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class WeatherController : Controller
    {
        // GET: Weather
        public ActionResult Index()
        {
            var weatherViewModel = new WeatherViewModel();

            weatherViewModel.WeatherInformation = Helper.GetWeatherInfo("alcudia");
            return View(weatherViewModel);
        }
    }
}