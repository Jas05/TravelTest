﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class BookingController : Controller
    {
        // GET: Booking
        [HttpGet]
        public ActionResult Index()
        {
            return View("View");
        }

        [HttpPost]
        public ActionResult Index(BookingViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (model.BookingRef == "123456" && model.LastName == "spectrum")
                {
                    return RedirectToAction("Index", "Details");
                   
                }
                return View("View");
            }
            else
            {
                return View("View");
            }
           
        }
        
    }
}