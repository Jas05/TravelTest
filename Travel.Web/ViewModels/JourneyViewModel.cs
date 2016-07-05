using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Travel.Web.Models;

namespace Travel.Web.ViewModels
{
    public class JourneyViewModel
    {
        public List<JourneyModel> journeyTypeList{ get; set; }

        [Required]
        public string NewJourneyType { get; set; }
    }
}