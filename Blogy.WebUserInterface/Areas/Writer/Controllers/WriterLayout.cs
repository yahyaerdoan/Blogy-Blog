using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class WriterLayout : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
