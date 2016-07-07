using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travel.Web.Models
{
    public class ActivityModel
    {
        public int ActivityId { get; set; }

        public string ActivityName { get; set; }

        public string ActivityDescription { get; set; }

        public string ActivityCost { get; set; }
    }
}