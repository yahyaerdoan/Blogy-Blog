using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.BlogDetailsViewComponents
{
    public class _BlogDetailByBlogCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
