using Blogy.EntityLayer.Concrete;
using Blogy.WebUserInterface.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Controllers.AdminController
{
    public class LogInAdminController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LogInAdminController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel userSignInViewModel)
        {
            if (userSignInViewModel.UserName != null && userSignInViewModel.Password != null ) 
            { 
                var result = await _signInManager.PasswordSignInAsync(userSignInViewModel.UserName, userSignInViewModel.Password, false, true);
                if (result.Succeeded) 
                {
                    return RedirectToAction("Index", "Category");
                }
                else
                {
                    ModelState.AddModelError("", "User Name or Password mistake");
                }
            }
            else
            {
                ModelState.AddModelError("", "User Name or Password can not be empty");
            }
            return View();
        }
    }
}