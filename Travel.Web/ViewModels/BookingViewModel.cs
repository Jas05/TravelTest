using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Travel.Web.ViewModels
{
    public class BookingViewModel
    {
        [Required]
        public string BookingRef { get; set; }

        [Required]
        public string LastName { get; set; }
    }
}