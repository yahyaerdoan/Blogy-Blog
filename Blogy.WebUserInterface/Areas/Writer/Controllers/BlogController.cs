using Blogy.BussinessLayer.Abstract;
using Blogy.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Blogy.WebUserInterface.Areas.Blogy.WriterArea.Controllers
{
    [Area("Writer")]
    [Route("Writer/{controller}/{action}/{id?}")]
    public class BlogController : Controller
    {
        private readonly IArticleService _articleService;
        private readonly ICategoryService _categoryService;
        private readonly UserManager<AppUser> _userManager;


        public BlogController(IArticleService articleService, UserManager<AppUser> userManager, ICategoryService categoryService)
        {
            _articleService = articleService;
            _userManager = userManager;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> MyBlogList()
        {          
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var values = _articleService.TGetArticlesByWriterId(user.Id);            
            return View(values);
        }
        [HttpGet]
        public async Task<IActionResult> CreateArticle()
        {
            GetCategoryName();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateArticle(Article article)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            article.AppUserId = values.Id;         
            _articleService.TAdd(article);
                    
            return RedirectToAction("MyBlogList");
        }
        public ActionResult DeleteArticle(int id)
        {
             _articleService.TDelete(id);
            return RedirectToAction("MyBlogList");
        }
        public void GetCategoryName()
        {
            ViewBag.CategoryName = new SelectList(_categoryService.TGetListAll(), "CategoryId", "Name");

            List<SelectListItem> selectListItems = (from i in _categoryService.TGetListAll()
                                                    select new SelectListItem
                                                    {
                                                        Text = i.Name,
                                                        Value = i.CategoryId.ToString()
                                                    }).ToList();
            ViewBag.CategoryName = selectListItems;
        }
    }
}