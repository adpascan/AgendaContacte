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
    public class IndexModel : PageModel
    {
        private readonly AgendaContacte.Data.AgendaContacteContext _context;

        public IndexModel(AgendaContacte.Data.AgendaContacteContext context)
        {
            _context = context;
        }

        public IList<Contact> Contact { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Contact != null)
            {
                Contact = await _context.Contact.ToListAsync();
            }
        }
    }
}
