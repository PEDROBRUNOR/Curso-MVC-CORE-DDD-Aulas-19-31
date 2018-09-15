using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Projeto.Curso.Core.Application.Pedido.Interfaces;

namespace Projeto.Curso.Core.Site.Areas.Cadastros.Controllers
{
    [Area("Cadastros")]
    public class ClientesController : Controller
    {

        private readonly IApplicationClientes appclientes;

        public ClientesController(IApplicationClientes _appclientes)
        {
            appclientes = _appclientes;
        }
        public IActionResult Index()
        {
            return View();
        }

        public JsonResult ListagemClientesJson()
        {
            var lista = appclientes.ObterTodos();
            var settings = new JsonSerializerSettings();
            return Json(lista, settings);
        }

        public IActionResult Incluir()
        {
            return View();
        }

    }
}