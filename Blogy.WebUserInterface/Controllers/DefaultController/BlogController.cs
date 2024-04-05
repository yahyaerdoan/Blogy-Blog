using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUserInterface.Controllers.DefaultController
{
	public class BlogController : Controller
	{
		public IActionResult BlogList()
		{
			return View();
		}

		public IActionResult BlogDetail(int id)
		{
			ViewBag.Id = id;
			return View();
		}
	}
}