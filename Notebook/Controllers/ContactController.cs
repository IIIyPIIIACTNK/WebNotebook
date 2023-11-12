using Microsoft.AspNetCore.Mvc;
using Notebook.Interfaces;
using Notebook.Repositories;
using Notebook.Seed;

namespace Notebook.Controllers
{
    public class ContactController : Controller
    {
        private IContactRepository _repository { get; }
        public ContactController(IContactRepository contactRepository)
        {
            _repository= contactRepository;
        }
        public IActionResult Index()
        {
            return View(_repository.GetAll());
        }

        public async Task<IActionResult> Detail(string id)
        {
            return View();
        } 
    }
}
