using Microsoft.AspNetCore.Mvc;

namespace cadastro_contatos_aspnet.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criar()
        {
            return View();
        }

        public IActionResult Editar()
        {
            return View();
        }

        public IActionResult ApagarConfirma()
        {
            return View();
        }

        public IActionResult ApagarContato()
        {
            return View();
        }
    }
}
