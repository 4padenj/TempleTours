using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;
using TempleTours.Models.ViewModels;

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ReservationsDbContext Context;
        
        public HomeController(ILogger<HomeController> logger, ReservationsDbContext con)
        {
            _logger = logger;
            Context = con;
        }

        //Index Action - no models needed?
        public IActionResult Index()
        {
            return View();
        }

        //Sign Up GET Action
        [HttpGet("SignUp")]
        public IActionResult SignUp()
        {
            return View(new DayOfWeekViewModel 
            {
                Monday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Monday" && x.Available == true),

                Tuesday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Tuesday" && x.Available == true),

                Wednesday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Wednesday" && x.Available == true),

                Thursday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Thursday" && x.Available == true),

                Friday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Friday" && x.Available == true),

                Saturday = Context.TourSlots
                    .Where(x => x.DayOfWeek == "Saturday" && x.Available == true)

            });
        }

        //Sign Up POST Action 
        [HttpPost("SignUp")]
        public IActionResult SignUp(TourSlot tourSlot)
        {
            //model validation
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                //TODO: add reservation to list
                ///redirect to homepage
                return View("Index");
            }
        }

        //View Appointments Action
        public IActionResult ViewAppointments()
        {       
            //possible list model
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
