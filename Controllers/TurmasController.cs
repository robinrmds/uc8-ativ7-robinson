using System.Collections.Generic;
using uc8ativ5_Robinson.Models;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace uc8ativ5_Robinson.Controllers
{
    public class TurmasController : Controller
    {
         
        public IActionResult ListarTurmas()
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            TurmaBanco turmaBanco = new TurmaBanco();
            List<TurmaOBJ> Lista = turmaBanco.ListarTurmas();
            return View(Lista);
        }
        public IActionResult CadastroTurmas()
        {
           if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            return View();
        }
        [HttpPost]
        public IActionResult CadastroTurmas(TurmaOBJ novaTurma)
        {
            
            TurmaBanco turmaBanco = new TurmaBanco();
            turmaBanco.Inserir(novaTurma);
            //ViewBag.Mensagem = "Cadastro concluído com sucesso!";
           /* ViewBag.Turma = novaTurma.Turma;
            ViewBag.Serie = novaTurma.Serie;
            ViewBag.Turno = novaTurma.AnoLetivo;
            ViewBag.Ativo = novaTurma.Ativo;*/

             return RedirectToAction("ListarTurmas");
        }
        
        
        public IActionResult RemoverTurmas(int id) {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            TurmaBanco turmaBanco = new TurmaBanco();
            turmaBanco.Remover(id);
            return RedirectToAction("ListarTurmas");
        }
        
        public IActionResult EditarTurmas(int id) {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            TurmaBanco turmaBanco = new TurmaBanco();
            TurmaOBJ turma = turmaBanco.BuscarPorId(id);
            
            return View(turma);
        }
        [HttpPost]
        public IActionResult EditarTurmas(TurmaOBJ pacote) {
            TurmaBanco turmaBanco = new TurmaBanco();
            turmaBanco.Atualizar(pacote);
            return RedirectToAction("ListarTurmas");
        }
    }
}