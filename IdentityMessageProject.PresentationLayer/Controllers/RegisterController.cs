using Microsoft.AspNetCore.Mvc;

namespace IdentityMessageProject.PresentationLayer.Controllers
{
    public class RegisterController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
    }
}
