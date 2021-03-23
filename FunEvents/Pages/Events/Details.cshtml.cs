using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FunEvents.Data;
using FunEvents.Models;

namespace FunEvents.Pages.Events
{
    public class DetailsModel : PageModel
    {
        public Event Event { get; set; }

        private readonly FunEvents.Data.ApplicationDbContext _context;
        private Attendee attendee = new Attendee();

        public DetailsModel(FunEvents.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event = await _context.Events.FirstOrDefaultAsync(m => m.ID == id);

            if (Event == null)
            {
                return NotFound();
            }
            return Page();
        }

        public IActionResult OnPost(int? id)
        {
            if (ModelState.IsValid)
            {
                attendee = _context.Attendees.Find(1);
                attendee.Events = _context.Events.Where(e => e.ID == id).ToList();

                _context.SaveChanges();
            }
            return Page();
        }
    }
}
