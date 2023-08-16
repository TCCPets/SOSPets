using Microsoft.AspNetCore.Mvc;

namespace SOSPets.Controllers
{
    public class DesaparecidosController : Controller
    {
        public IActionResult Desaparecidos()
        {
            return View();
        }
    }
}
