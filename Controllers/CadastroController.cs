using Microsoft.AspNetCore.Mvc;

namespace SOSPets.Controllers
{
    public class CadastroController : Controller
    {
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}
