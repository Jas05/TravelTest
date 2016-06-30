using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.Interfaces;
using Travel.Web.Models;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class JourneyController : Controller
    {
        private readonly IJourneyService journeyService;

        public JourneyController(IJourneyService _journeyService)
        {
            journeyService = _journeyService;
        }

        // GET: Journey
        public ActionResult Index()
        {
            var viewModel = new JourneyViewModel();
            var journeyTypes = journeyService.GetAllJourneyTypes();
            foreach (var journeyType in journeyTypes)
            {
                viewModel.journeyTypeList.Add(new JourneyModel
                {
                    Id = journeyType.Id,
                    Name = journeyType.Name
                });
             }

            return View(viewModel);
        }
    }
}