using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents
{
	public class _BlogListBlogListSectionComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
