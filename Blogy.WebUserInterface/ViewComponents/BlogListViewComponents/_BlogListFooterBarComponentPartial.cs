﻿using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.ViewComponents.BlogListViewComponents
{
    public class _BlogListFooterBarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }

}