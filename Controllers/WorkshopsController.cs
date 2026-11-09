using System.Diagnostics;
using System.Threading.Tasks;
using Lab3.Data;
using Lab3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Lab3.Controllers
{
    public class WorkshopsController : Controller
    {
        private readonly RsvpDBContext _context;

        public WorkshopsController (RsvpDBContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Confirm(Rsvp rsvp)
        {
            if (ModelState.IsValid)
            {
                ViewData["message"] = "Thanks for registering," + rsvp.FullName;
                _context.Add(rsvp);
                await _context.SaveChangesAsync();
            }
            return View(rsvp);
        }

        public async Task<IActionResult> Registrations()
        {
            var rsvps = from r in _context.Rsvps select r;
            return View(await rsvps.ToListAsync());
        }
    }
}
