using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Controllers.DefaultController
{
	public class BlogController : Controller
	{
		private readonly IArticleService _articleService;

		public BlogController(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IActionResult BlogList()
		{
			var values = _articleService.TGetListAll();
			return View(values);
		}
	}
}
