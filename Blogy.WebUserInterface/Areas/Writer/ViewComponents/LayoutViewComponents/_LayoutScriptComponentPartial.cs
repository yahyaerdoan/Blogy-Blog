using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Areas.Writer.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}