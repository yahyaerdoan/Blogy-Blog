using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Controllers.AdminController
{
    public class StatisticController : Controller
    {
        private readonly ICategoryService _categoryService;

        public StatisticController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            ViewBag.CategoryCount = _categoryService.TGetCategoryCount();
            return View();
        }
    }
}
