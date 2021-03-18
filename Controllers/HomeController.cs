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
                    .Where(x => x.TimeInfo.Day == 22 && x.Available == true).OrderBy(x => x.TimeInfo),

                Tuesday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 23 && x.Available == true).OrderBy(x => x.TimeInfo),

                Wednesday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 24 && x.Available == true).OrderBy(x => x.TimeInfo),

                Thursday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 25 && x.Available == true).OrderBy(x => x.TimeInfo),

                Friday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 26 && x.Available == true).OrderBy(x => x.TimeInfo),

                Saturday = Context.TourSlots
                    .Where(x => x.TimeInfo.Day == 27 && x.Available == true).OrderBy(x => x.TimeInfo)

            });
        
        }

        [HttpPost("SignUp")]
        public IActionResult SignUp(TourSlot tourslot)
        {
            TourSlot slot = tourslot;
            // Update the slot to be available = false
            // Set ViewData = slot
            return RedirectToAction("ReservationInfo", slot);
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
                     .Where(x => x.TimeInfo.Day == 22 && x.Available == false).OrderBy(x => x.TimeInfo),

                Tuesday = Context.TourSlots
                     .Where(x => x.TimeInfo.Day == 23 && x.Available == false).OrderBy(x => x.TimeInfo),

                Wednesday = Context.TourSlots
                     .Where(x => x.TimeInfo.Day == 24 && x.Available == false).OrderBy(x => x.TimeInfo),

                Thursday = Context.TourSlots
                     .Where(x => x.TimeInfo.Day == 25 && x.Available == false).OrderBy(x => x.TimeInfo),

                Friday = Context.TourSlots
                     .Where(x => x.TimeInfo.Day == 26 && x.Available == false).OrderBy(x => x.TimeInfo),

                Saturday = Context.TourSlots
                     .Where(x => x.TimeInfo.Day == 27 && x.Available == false).OrderBy(x => x.TimeInfo)

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
