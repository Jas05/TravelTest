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
            viewModel.journeyTypeList = new List<JourneyModel>();
            var journeyTypes = journeyService.GetAllJourneyTypes();
            PopulateJourneyTypeList(viewModel, journeyTypes);

            return View(viewModel);
        }

        public ActionResult Create(string newJourneyType)
        {
            var viewModel = new JourneyViewModel();
            viewModel.journeyTypeList = new List<JourneyModel>();

            if (!string.IsNullOrEmpty(newJourneyType))
            {
                var model = journeyService.CreateNewJourneyType(newJourneyType);

                PopulateJourneyTypeList(viewModel, model);
            }

            return View(viewModel);
        }

        public ActionResult Delete(int id)
        {
            var viewModel = new JourneyViewModel();
            viewModel.journeyTypeList = new List<JourneyModel>();
            var model = journeyService.DeleteJourneyType(id);

            PopulateJourneyTypeList(viewModel, model);
            return View(viewModel);
        }

        private static void PopulateJourneyTypeList(JourneyViewModel viewModel, List<DAL.JourneyType> model)
        {
            foreach (var journeyType in model)
            {
                viewModel.journeyTypeList.Add(new JourneyModel
                {
                    Id = journeyType.Id,
                    Name = journeyType.Name
                });
            }
        }
    }
}