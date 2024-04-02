using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByWriterInformationComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
