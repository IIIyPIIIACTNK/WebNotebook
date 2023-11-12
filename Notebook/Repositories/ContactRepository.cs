using Microsoft.EntityFrameworkCore;
using Notebook.Data;
using Notebook.Interfaces;
using Notebook.Models;

namespace Notebook.Repositories
{
    public class ContactRepository : IContactRepository
    {
        private ApplicationDbContext _dbContext { get; }
        public ContactRepository(ApplicationDbContext dbContext)
        {
            _dbContext= dbContext;
        }

        public Task<List<Contact>> GetAll()
        {
            return _dbContext.Contacts.ToListAsync();
        }
    }
}
