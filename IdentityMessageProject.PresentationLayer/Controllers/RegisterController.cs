using IdentityMessageProject.EntityLayer.Concrete;
using IdentityMessageProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityMessageProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        //nesne ornegı ıcın constraction yaptık
        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(RegisterViewModel model)
        {
          AppUser appuser = new AppUser()
            {
              
                UserName = model.Name,
                Email= model.Email,
                UserSurname = model.Surname,
                //Username = model.Username
            };
            var result =await _userManager.CreateAsync(appuser, model.Password);
            if (result.Succeeded) {
                return RedirectToAction("Index", "Login");
            }
            return View();
        }
    }
}
