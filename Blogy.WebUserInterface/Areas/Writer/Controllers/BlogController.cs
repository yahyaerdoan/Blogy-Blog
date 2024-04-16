using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Areas.Blogy.WriterArea.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
