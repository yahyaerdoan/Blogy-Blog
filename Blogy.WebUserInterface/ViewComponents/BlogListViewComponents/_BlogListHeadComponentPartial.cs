using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogListViewComponents
{
    public class _BlogListHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}