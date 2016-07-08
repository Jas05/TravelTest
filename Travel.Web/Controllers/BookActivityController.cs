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
        public ActionResult Index(string title, string largeImageURL, string fromPrice, string fromOriginalPriceValue, string duration, string supplierName )
        {

            var viewModel = new Activity2();
            viewModel.title = title;
            viewModel.largeImageURL = largeImageURL;
            viewModel.fromPrice = fromPrice;
            viewModel.duration = duration;
            viewModel.supplierName = supplierName;
            return View(viewModel);
        }
    }
}