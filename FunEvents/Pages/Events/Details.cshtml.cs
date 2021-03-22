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
        private readonly FunEvents.Data.ApplicationDbContext _context;

        public DetailsModel(FunEvents.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Event Event { get; set; }
        [BindProperty]
        public Attendee Attendee { get; set; }

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if(ModelState.IsValid)
            {
                Attendee = await _context.Attendees.FindAsync(1);
                Event = await _context.Events.FindAsync(id);

                _context.AttendeeEvents.Add(new AttendeeEvent() {Attendee=Attendee, Event=Event });
                _context.SaveChanges();
            }
            return Page();
        }
    }
}
