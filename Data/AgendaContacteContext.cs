using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AgendaContacte.Models;

namespace AgendaContacte.Data
{
    public class AgendaContacteContext : DbContext
    {
        public AgendaContacteContext (DbContextOptions<AgendaContacteContext> options)
            : base(options)
        {
        }

        public DbSet<AgendaContacte.Models.Contact> Contact { get; set; } = default!;
    }
}
