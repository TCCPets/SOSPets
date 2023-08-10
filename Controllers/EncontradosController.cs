using Microsoft.AspNetCore.Mvc;

namespace SOSPets.Controllers
{
    public class EncontradosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
