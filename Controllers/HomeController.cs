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

        [HttpGet("SignUp")]
        public IActionResult SignUp()
        {
            return View(new DayOfWeekViewModel 
            {
                Monday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 1 && x.Available == true).OrderBy(x => x.TimeInfo),

                Tuesday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek == DayOfWeek.Tuesday && x.Available == true).OrderBy(day => day.TimeInfo),

                Wednesday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Wednesday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Thursday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Thursday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Friday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Friday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Saturday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Saturday" && x.Available == true).OrderBy(day => day.TimeInfo)

            });
        
        }

        [HttpPost("SignUp")]
        public IActionResult SignUp(TourSlot tourslot)
        {
            return View("ReservationInfo");
        }


        [HttpGet("ReservationInfo")]
        public IActionResult ReservationInfo()
        {
            return View();
        }

        //Sign Up POST Action 
        [HttpPost("ReservationInfo")]
        public IActionResult ReservationInfo(TourSlot tourSlot)
        {
            //model validation
            if (ModelState.IsValid)
            {
                //update DB & redirect to View Appointments
                Context.TourSlots.Add(tourSlot);
                Context.SaveChanges();
                return View("ViewAppointments");
            }
            else
            {
                return View();
            }
        }



        //View Appointments Action
        public IActionResult ViewAppointments()
        {
            //pass in reservations
            return View(new DayOfWeekViewModel
            {
                Monday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Monday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Tuesday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Tuesday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Wednesday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Wednesday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Thursday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Thursday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Friday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Friday" && x.Available == true).OrderBy(day => day.TimeInfo),

                Saturday = Context.TourSlots
                    .Where(x => x.TimeInfo.DayOfWeek.ToString() == "Saturday" && x.Available == true).OrderBy(day => day.TimeInfo)

            });
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
