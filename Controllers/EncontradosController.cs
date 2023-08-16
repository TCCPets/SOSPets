using Microsoft.AspNetCore.Mvc;

namespace SOSPets.Controllers
{
    public class EncontradosController : Controller
    {
        public IActionResult Encontrados()
        {
            return View();
        }
    }
}
