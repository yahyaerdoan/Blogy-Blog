using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByWriterInformationComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

        public _BlogDetailByWriterInformationComponentPartial(IArticleService articleService)
        {
            _articleService = articleService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetWriterInfoByArticleWriter(id);
            return View(values);
        }
    }
}
