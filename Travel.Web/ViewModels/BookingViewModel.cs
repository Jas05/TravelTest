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
        [Display(Name ="Booking reference")]
        public string BookingRef { get; set; }

        [Required]
        [Display(Name ="Last name")]
        public string LastName { get; set; }
    }
}