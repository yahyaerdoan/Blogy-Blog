using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Areas.Blogy.WriterArea.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {
        public IActionResult MyBlogList()
        {
            return View();
        }
    }
}