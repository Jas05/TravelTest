using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Travel.Core.DAL;
using Travel.Web.ViewModels;

namespace Travel.Web.Controllers
{
    public class AlertsController : Controller
    {
        // GET: Notification
        public ActionResult Index(string bookingId)
        {
            var datamanager = new DataManager();
            var notificationsViewModel = new NotificationViewModel();
            notificationsViewModel.Notifications = datamanager.GetNotification(bookingId);
            notificationsViewModel.InResort = datamanager.GetInResort(bookingId);



            return View(notificationsViewModel);
        }
    }
}