using cadastro_contatos_aspnet.Models;
using cadastro_contatos_aspnet.Repositorios;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace cadastro_contatos_aspnet.Controllers
{


    public class ContatosController : Controller
    {

        private readonly IContatoRepositorio _contatoRepositorio;

        public ContatosController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
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

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            _contatoRepositorio.Adicionar(contato);
            return RedirectToAction("Index", "ContatosController");
        }
    }
}
