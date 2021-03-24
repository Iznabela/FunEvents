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
        [BindProperty]
        public Event Event { get; set; }
        [BindProperty]
        public Attendee Attendee { get; set; }

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            
            if (ModelState.IsValid)
            {
                Event = await _context.Events.FindAsync(id);
                Attendee = await _context.Attendees.FindAsync(5);
                attendee = await _context.Attendees.FindAsync(5);
                attendee.Events = await _context.Events.Where(e => e.ID == id).ToListAsync();
                Event.SpotsAvailable = Event.SpotsAvailable - 1;

                //foreach(var item in attendee.Events)
                //{
                //    if (item.ID == id)
                //    {
                //        return Page();
                //    }
                //}
              
                _context.SaveChanges();   
            }
            return Page();
        }
    }
}
