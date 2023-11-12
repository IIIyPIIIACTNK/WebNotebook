using Microsoft.EntityFrameworkCore;
using Notebook.Models;

namespace Notebook.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        DbSet<Contact> Contacts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=notebookdb;Username=postgres;Password=postgres");
        }
    }
}
