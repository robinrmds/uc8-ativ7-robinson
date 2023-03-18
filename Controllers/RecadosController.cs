using System.Collections.Generic;
using uc8ativ5_Robinson.Models;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace uc8ativ5_Robinson.Controllers
{
    public class RecadosController : Controller
    {
         
        public IActionResult ListarRecados()
        {
           if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            RecadoBanco RecadoBanco = new RecadoBanco();
            List<RecadoOBJ> Lista = RecadoBanco.ListarRecados("normal");
            return View(Lista);
        }
        public IActionResult CadastroRecados()
        {
           if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            return View();
        }
        [HttpPost]
        public IActionResult CadastroRecados(RecadoOBJ novoRecado)
        {
            
            RecadoBanco RecadoBanco = new RecadoBanco();
            RecadoBanco.Inserir(novoRecado);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
           /* ViewBag.recado = novoRecado.recado;
            ViewBag.Serie = novoRecado.Serie;
            ViewBag.Turno = novoRecado.AnoLetivo;
            ViewBag.Ativo = novoRecado.Ativo;*/

             return RedirectToAction("ListarRecados");
        }
        
        
        public IActionResult RemoverRecados(int id) {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            RecadoBanco RecadoBanco = new RecadoBanco();
            RecadoBanco.Remover(id);
            return RedirectToAction("ListarRecados");
        }
        
        public IActionResult EditarRecados(int id) {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            RecadoBanco RecadoBanco = new RecadoBanco();
            RecadoOBJ recado = RecadoBanco.BuscarPorId(id);
            
            return View(recado);
        }
        [HttpPost]
        public IActionResult EditarRecados(RecadoOBJ recado1) {
            RecadoBanco RecadoBanco = new RecadoBanco();
            
            RecadoBanco.Atualizar(recado1);
            return RedirectToAction("ListarRecados");
        }
    }
}