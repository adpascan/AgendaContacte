using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using AgendaContacte.Data;
using AgendaContacte.Models;

namespace AgendaContacte.Pages.Contacts
{
    public class DetailsModel : PageModel
    {
        private readonly AgendaContacte.Data.AgendaContacteContext _context;

        public DetailsModel(AgendaContacte.Data.AgendaContacteContext context)
        {
            _context = context;
        }

      public Contact Contact { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Contact == null)
            {
                return NotFound();
            }

            var contact = await _context.Contact.FirstOrDefaultAsync(m => m.ID == id);
            if (contact == null)
            {
                return NotFound();
            }
            else 
            {
                Contact = contact;
            }
            return Page();
        }
    }
}
