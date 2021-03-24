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
        private readonly FunEvents.Data.ApplicationDbContext _context;

        public IndexModel(FunEvents.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Attendee Attendee { get;set; }

        public async Task<IActionResult> OnGetAsync()
        {
            Attendee = await _context.Attendees
                .Include(s => s.Events)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.ID == 5);

            if (Attendee == null)
            {
                return NotFound();
            }

            return Page();
        }

    }
}
