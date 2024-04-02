using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByOtherCommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
