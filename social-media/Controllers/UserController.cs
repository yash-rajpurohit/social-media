using Microsoft.AspNetCore.Mvc;

namespace social_media.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
