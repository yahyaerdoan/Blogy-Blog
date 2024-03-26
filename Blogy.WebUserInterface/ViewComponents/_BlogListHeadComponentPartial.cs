using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents
{
	public class _BlogListHeadComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
