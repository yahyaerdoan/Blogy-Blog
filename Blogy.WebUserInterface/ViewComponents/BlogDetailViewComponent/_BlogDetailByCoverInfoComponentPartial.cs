﻿using Blogy.BussinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogDetailViewComponent
{
    public class _BlogDetailByCoverInfoComponentPartial : ViewComponent
    {
        private readonly IArticleService _articleService;

		public _BlogDetailByCoverInfoComponentPartial(IArticleService articleService)
		{
			_articleService = articleService;
		}

		public IViewComponentResult Invoke(int id)
        {
            var values = _articleService.TGetById(id);
            return View(values);
        }
    }
}
