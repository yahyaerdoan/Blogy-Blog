using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByTagsCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}