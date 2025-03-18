using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace CarBookingApp.Pages
{
    [AllowAnonymous]
    public class CarsModel : PageModel
    {
        public string HeadingText { get; set; } = string.Empty;
        public void OnGet()
        {
            HeadingText = "Welcome to the Car Booking App!";
        }
    }
}