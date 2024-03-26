using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents
{
	public class _BlogListFooterBarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
