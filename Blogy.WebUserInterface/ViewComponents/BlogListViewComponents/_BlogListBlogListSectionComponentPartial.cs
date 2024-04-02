using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUserInterface.ViewComponents.BlogListViewComponents
{
    public class _BlogListBlogListSectionComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogListBlogListSectionComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }
        public IViewComponentResult Invoke()
        {
            var values = _articleService.TGetArticlesWithWriter();
            return View(values);
        }
    }
}