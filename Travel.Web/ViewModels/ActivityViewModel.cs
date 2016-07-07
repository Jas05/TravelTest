using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Travel.Core.DomainEntities;
using Travel.Web.Models;

namespace Travel.Web.ViewModels
{
    public class ActivityViewModel
    {
        public List<Activity> Activities { get; set; }
    }
}