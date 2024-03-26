using Blogy.EntityLayer.Concrete;
using Blogy.WebUserInterface.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Blogy.WebUserInterface.Controllers.AdminController
{
    public class RegisterAdminController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterAdminController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateRegisteriewModel createRegisteriewModel)
        {
            if (createRegisteriewModel.Password != null)
            {
                AppUser appUser = new AppUser()
                {
                    FirstName = createRegisteriewModel.FirstName,
                    LastName = createRegisteriewModel.LastName,
                    Email = createRegisteriewModel.Email,
                    UserName = createRegisteriewModel.Username,
                    Description = "aa",
                    Image = "aa"
                };

                var result = await _userManager.CreateAsync(appUser, createRegisteriewModel.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
                return View();
            }
            else
            {
                ModelState.AddModelError("", "Password can not be empty");
                return View();
            }            
        }
    }
}
