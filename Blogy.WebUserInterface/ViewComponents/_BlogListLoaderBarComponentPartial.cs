using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents
{
	public class _BlogListLoaderBarComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
