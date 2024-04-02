using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.BlogDetailsViewComponents
{
    public class _BlogDetailByCoverInfoComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {           
            return View();
        }
    }
}
