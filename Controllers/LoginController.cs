using System.Collections.Generic;
using uc8ativ5_Robinson.Models;
using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace uc8ativ5_Robinson.Controllers
{
    public class LoginController : Controller
    {
        

        public IActionResult Login()
        {
             if(HttpContext.Session.GetInt32("IdUsuario") == null){
                ViewBag.isLogon = false;
            }else{
                ViewBag.isLogon = true;
               
            }
            return View("Login");
            //return RedirectToAction("Login/?login=false");
        }


        [HttpPost]
        public IActionResult Login(UsuarioOBJ usuario)
        {
            UsuarioBanco usuarioBanco = new UsuarioBanco();
           // Usuario usuarioSessao = usuarioBanco.ValidarLogin(usuario);
            int temp = usuarioBanco.ValidarLoginID(usuario);
            
            //Console.WriteLine("ID do usuario RETORNO LOGIN " + (string)temp.ToString());
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
                ViewBag.isLogon = false;
                //RegisterModel model = new RegisterModel();
                //TO DO:
                //Console.WriteLine("Entrou no ELSE ");
                //return View("Login", "_LoginAdmin");
                return View();
            }
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login","Login");
            
        }
    }
}