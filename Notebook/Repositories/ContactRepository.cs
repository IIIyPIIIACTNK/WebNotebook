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

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return await _dbContext.Contacts.ToListAsync();
        }
    }
}
