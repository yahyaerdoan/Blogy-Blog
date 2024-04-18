using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Areas.Blogy.WriterArea.Controllers
{
    [Area("Writer")]
    public class BlogController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly UserManager<AppUser> _userManager;


        public BlogController(IArticleService articleService, UserManager<AppUser> userManager)
        {
            _articleService = articleService;
            _userManager = userManager;
        }

        public async Task<IActionResult> MyBlogList()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //ViewBag.UserInfo = user.FirstName + " " + user.LastName;
            var values = _articleService.TGetArticlesByWriterId(user.Id);
            return View(values);
        }
    }
}