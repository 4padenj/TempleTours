using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TempleTours.Models;

namespace TempleTours.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
            return View();
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
                //TODO: add 
                return View();
            }
        }

        //View Appointments Action
        public IActionResult ViewAppointments()
        {
            //TODO: What model belongs here?
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
