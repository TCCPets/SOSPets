using Microsoft.AspNetCore.Mvc;

namespace SOSPets.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
