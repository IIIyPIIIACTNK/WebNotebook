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
    }
}
