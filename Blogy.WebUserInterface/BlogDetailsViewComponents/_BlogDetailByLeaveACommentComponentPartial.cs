using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.BlogDetailsViewComponents
{
    public class _BlogDetailByLeaveACommentComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
