using Notebook.Models;

namespace Notebook.Interfaces
{
    public interface IContactRepository
    {
        public Task<List<Contact>> GetAll();
    }
}
