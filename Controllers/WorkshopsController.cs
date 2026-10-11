using System.Diagnostics;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        private static List<Rsvp> rsvps = new List<Rsvp>();
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Confirm(Rsvp rsvp)
        {
            ViewData["message"] = "Thanks for registering,"+rsvp.FullName;
            rsvps.Add(rsvp);
            return View(rsvp);
        }

        public  IActionResult Registrations()
        {

            return View(rsvps);
        }
    }
}
