using Microsoft.AspNetCore.Mvc;
using Notebook.Seed;

namespace Notebook.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View(TestContactList.Contacts);
        }

        public async Task<IActionResult> Detail(string id)
        {
            return View(TestContactList.Contacts.Find(o => o.Id == id));
        } 
    }
}
