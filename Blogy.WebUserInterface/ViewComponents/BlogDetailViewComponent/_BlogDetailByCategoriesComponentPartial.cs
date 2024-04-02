using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByCategoriesComponentPartial : ViewComponent
    {
        private readonly ICategoryService _categoryService;

        public _BlogDetailByCategoriesComponentPartial(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _categoryService.TGetListAll();
            return View(values);
        }
    }
}
