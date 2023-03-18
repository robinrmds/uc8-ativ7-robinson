using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using uc8ativ5_Robinson.Models;
using Microsoft.AspNetCore.Http;

namespace uc8ativ5_Robinson.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        

        public IActionResult Index()
        {
            RecadoBanco RecadoBanco = new RecadoBanco();
            List<RecadoOBJ> Lista = RecadoBanco.ListarRecados("vitrine");
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            if(HttpContext.Session.GetInt32("IdUsuario") == null){
                ViewBag.isLogon = false;
            }else{
                ViewBag.isLogon = true;
            }
            return View(Lista);
        }

        public IActionResult cadastro_usuarios()
        {
            return View();
        }
		
		public IActionResult cadastro_turmas()
        {
            return View();
        }
		
		public IActionResult usuario()
        {
            return View();
        }
		
		public IActionResult turmas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
