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
    public class IndexModel : PageModel
    {
        private readonly FunEvents.Data.ApplicationDbContext _context;

        public IndexModel(FunEvents.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Event> Events { get;set; }

        public async Task OnGetAsync()
        {
            Events = await _context.Events.ToListAsync();
        }
    }
}
