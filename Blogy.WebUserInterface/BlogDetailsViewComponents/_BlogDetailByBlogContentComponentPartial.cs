using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogContentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
