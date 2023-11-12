using Microsoft.AspNetCore.Mvc;

namespace Notebook.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
