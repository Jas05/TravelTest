using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Core.DomainEntities;
using Travel.Web.Models;

namespace Travel.Web.ViewModels
{
    public class NotificationViewModel
    {
        public List<Notification> Notifications { get; set; }
        public List<Notification> Offers { get; set; }
    }
}