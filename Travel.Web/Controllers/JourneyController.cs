using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Web.Models;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class JourneyController : Controller
    {
        // private readonly IJourneyService journeyService;

        //public JourneyController(IJourneyService _journeyService)
        //{
        //    journeyService = _journeyService;
        //}

        //// GET: Journey
        //public ActionResult Index()
        //{
        //    var viewModel = new JourneyViewModel();
        //    viewModel.journeyTypeList = new List<JourneyModel>();
        //    var journeyTypes = journeyService.GetAllJourneyTypes();
        //    PopulateJourneyTypeList(viewModel, journeyTypes);

        //    return View(viewModel);
        //}

        //public bool Create(string newJourneyType)
        //{
        //    var viewModel = new JourneyViewModel();
        //    viewModel.journeyTypeList = new List<JourneyModel>();

        //    if (!string.IsNullOrEmpty(newJourneyType))
        //    {
        //        var model = journeyService.CreateNewJourneyType(newJourneyType);

        //        PopulateJourneyTypeList(viewModel, model);
        //    }

        //    return true;

        //    // RedirectToAction("Index", "Journey");
        //}

        //public bool Delete(int id)
        //{
        //    var viewModel = new JourneyViewModel();
        //    viewModel.journeyTypeList = new List<JourneyModel>();
        //    var model = journeyService.DeleteJourneyType(id);

        //    PopulateJourneyTypeList(viewModel, model);
        //    return true;
        //}

        //public ActionResult Edit(int id, string journeyTypeName)
        //{
        //    var viewModel = new JourneyViewModel();
        //    viewModel.journeyTypeList = new List<JourneyModel>();
        //    viewModel.JourneyTypeId = id;
        //    viewModel.JourneyType = journeyTypeName.Trim();
        //    return View(viewModel);
        //}

        //public ActionResult EditJourneyType(int id, string journeyTypeName)
        //{
        //    var journeyModel = new JourneyModel()
        //    {
        //        Id = id,
        //        Name = journeyTypeName.Trim()
        //    };
        //    journeyService.EditJourneyType(id, journeyTypeName);

        //    var viewModel = new JourneyViewModel();
        //    viewModel.journeyTypeList = new List<JourneyModel>();
        //    var journeyTypes = journeyService.GetAllJourneyTypes();
        //    PopulateJourneyTypeList(viewModel, journeyTypes);


        //    return View("Index", viewModel);
        //} 

        //private static void PopulateJourneyTypeList(JourneyViewModel viewModel, List<DAL.JourneyType> model)
        //{
        //    foreach (var journeyType in model)
        //    {
        //        viewModel.journeyTypeList.Add(new JourneyModel
        //        {
        //            Id = journeyType.Id,
        //            Name = journeyType.Name
        //        });
        //    }
        //}


    }
}