using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Controllers.AdminController
{
    public class CategoryAdminController : Controller
    {
        public readonly ICategoryService _categoryService;
        public CategoryAdminController(ICategoryService categoryService)
        {
                _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult CreateCategory()
        {           
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            _categoryService.TAdd(category);
            return RedirectToAction("Index");
        }
        
        public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
           var values = _categoryService.TGetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {           
            _categoryService.TUpdate(category);            
            return RedirectToAction("Index");
        }
    }
}