using Microsoft.EntityFrameworkCore;

namespace AgendaContacte.Models
{
    public class AgendaContext : DbContext
    {
        public DbSet<Grup> Grupuri { get; set; }
        public DbSet<Contact> Contacte { get; set; }
        public DbSet<ContactGrup> ContacteGrupuri { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=AgendaDB;Trusted_Connection=True;");
        }
    }
}