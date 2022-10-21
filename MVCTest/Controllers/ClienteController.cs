using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCTest.Models;

namespace MVCTest.Controllers
{
    //[Route("[controller]")]
    
    public class ClienteController : Controller
    {
        private readonly ILogger<ClienteController> _logger;

        public ClienteController(ILogger<ClienteController> logger)
        {
            _logger = logger;
        }
        //[HttpGet]
        public string Index(int id)
        {
            return "Cliente " + id;
        }
        //[HttpGet]
        public string Index(int id, string name)
        {
            return "Cliente: " + id +";Nombre: "+name;
        }
        //[HttpGet]
        public IActionResult ConsultaCliente(Cliente ShowCliente)
    {
        
        //Redireccion();
        //return View("Hola");
        //return RedirectToAction("Redireccion");
        return View(ShowCliente);
    }
    public IActionResult RedireccionHome()
    {
        return RedirectToAction("Index","Home");
    }
    public IActionResult SubidaExitosa()
    {
        return View();
    }
        [HttpPost]
       public IActionResult AltaCliente(Cliente nuevoCliente){
            
           return RedirectToAction("SubidaExitosa");
        }
        public IActionResult getAltaCliente(){
            
           return View("AltaCliente");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}