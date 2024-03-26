using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents
{
	public class _BlogListScriptComponentPartial : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}

}
