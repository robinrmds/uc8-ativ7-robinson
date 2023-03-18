using System.Collections.Generic;
using uc8ativ5_Robinson.Models;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace uc8ativ5_Robinson.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult ListarUsuarios()
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");

            UsuarioBanco usuarioBanco = new UsuarioBanco();
            List<UsuarioOBJ> Lista = usuarioBanco.ListarUsuarios();
            return View(Lista);
        }

        public IActionResult CadastroUsuarios()
        {
            //Console.WriteLine(HttpContext.Session);
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            TurmaBanco turmabanco = new TurmaBanco();
            ViewBag.ListaTurmas = turmabanco.ListarTurmas();
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            ViewBag.ListResponsavel = usuarioBanco.isResponsavel();

            return View();
        }

        [HttpPost]
        public IActionResult CadastroUsuarios(UsuarioOBJ usuario)
        {
           if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");      
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.Inserir(usuario);
            ViewBag.Mensagem = "Cadastro realizado com sucesso!";
            
            return RedirectToAction("ListarUsuarios");           
        }


        public IActionResult EditarUsuarios(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            UsuarioOBJ usuario = usuarioBanco.BuscarPorId(Id);
            TurmaBanco turmabanco = new TurmaBanco();
            ViewBag.isAluno = usuario.EhAluno;
            ViewBag.isProfessor = usuario.EhProfessor;
            ViewBag.isFuncionario = usuario.EhFuncionario;
            ViewBag.isResponsavel = usuario.EhFuncionario;
            ViewBag.ListResponsavel = usuarioBanco.isResponsavel();
            ViewBag.ListaTurmas = turmabanco.ListarTurmas();
            
            return View(usuario);
        }

        [HttpPost]
        public IActionResult EditarUsuarios(UsuarioOBJ usuario)
        {
           if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");         
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.Atualizar(usuario);
            ViewBag.Mensagem = "Usuario atualizado com sucesso!";
            return RedirectToAction("ListarUsuarios");
        }

        public IActionResult Remover(int Id)
        {
            if(HttpContext.Session.GetInt32("IdUsuario") == null)
                return RedirectToAction("Login","Login");
            UsuarioBanco usuarioBanco = new UsuarioBanco();
            usuarioBanco.Remover(Id);
            return RedirectToAction("Lista");           
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UsuarioOBJ usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
           // Usuario usuarioSessao = usuarioBanco.ValidarLogin(usuario);
            int temp = usuarioBanco.ValidarLoginID(usuario);
            Console.WriteLine("ID do usuario RETORNO LOGIN " + (string)temp.ToString());

            if(temp > 0) 
            {
                UsuarioOBJ usuarioSessao = usuarioBanco.BuscarPorId(temp);
                //Console.WriteLine("Entou no IF IdUsusuario REtorno: ", usuarioSessao.Nome);
                ViewBag.Mensagem="Você está logado!";
                HttpContext.Session.SetInt32("IdUsuario", usuarioSessao.Id);
                HttpContext.Session.SetString("NomeUsuario", usuarioSessao.Nome);

                return RedirectToAction("Index","Home");
            } else {
                ViewBag.Mensagem = "Falha no login!";
                //RegisterModel model = new RegisterModel();
                //TO DO:
                return View("Login", "_LoginAdmin");
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Usuario");
            
        }
    }
}