﻿using Microsoft.AspNetCore.Mvc;
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
        public int savedID;
        public DateTime savedTime;
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
             savedID = tourslot.TourSlotID;
            savedTime = tourslot.TimeInfo;
            ViewBag.Time = savedTime;

            

            Context.TourSlots.First(x => x.TourSlotID == savedID).Available = false;
            Context.SaveChanges();
            // Update the slot to be available = false
            // Set ViewData = slot
            //ViewData["tourslot"] = slot;
            return View("ReservationInfo");
        }


        [HttpGet("ReservationInfo")]
        public IActionResult ReservationInfo()
        {
            return View();
        }

        //Sign Up POST Action 
        [HttpPost("ReservationInfo")]
        public IActionResult ReservationInfo(Reservation reservation)
        {
            //model validation
            if (ModelState.IsValid)
            {
                //update DB & redirect to View Appointments
                
                Context.Reservations.Add(reservation);
                Context.SaveChanges();
                Console.WriteLine(savedID);
                return View("Index");
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
            return View(new ViewAppointmentsViewModel
            {
                Monday = Context.Reservations
                     .Where(x => x.Time.Day == 22).OrderBy(x => x.Time),

                Tuesday = Context.Reservations
                     .Where(x => x.Time.Day == 23).OrderBy(x => x.Time),

                Wednesday = Context.Reservations
                     .Where(x => x.Time.Day == 24).OrderBy(x => x.Time),

                Thursday = Context.Reservations
                     .Where(x => x.Time.Day == 25).OrderBy(x => x.Time),

                Friday = Context.Reservations
                     .Where(x => x.Time.Day == 26).OrderBy(x => x.Time),

                Saturday = Context.Reservations
                     .Where(x => x.Time.Day == 27).OrderBy(x => x.Time)

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
