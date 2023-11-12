using Notebook.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Query.Expressions.Internal;

namespace Notebook.Interfaces
{
    public interface IContactRepository
    {
        public Task<IEnumerable<Contact>> GetAll();

        public Task<Contact> GetByIdAsync(string id);
        
    }
}
