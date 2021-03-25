using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FunEvents.Data;
using FunEvents.Models;

namespace FunEvents.Pages.MyEvents
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Event Event { get; set; }
        [BindProperty]
        public Attendee Attendee { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Attendee = await _context.Attendees
                .Include(s => s.Events)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == 1);

            if (Attendee == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPost(int? id)
        {
            Attendee = await _context.Attendees
                .Include(s => s.Events)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == 1);

            Event = await _context.Events.FindAsync(id);

            // REMOVE ATTENDEEEVENT
            _context.SaveChanges();
            return Page();
        }
    }
}
