﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JRMarketing.Gui.Models;
using System.Net.Http;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;
using JRMarketing.Gui.Responses;

namespace JRMarketing.Gui.Controllers
{
    public class HomeController : Controller
    {


        
        HttpClient client = new HttpClient();
        public string url = "https://localhost:44350/api/usuario";
 

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> IndexAsync(LoginModel login)
        {
            string route;
            var json = await client.GetStringAsync("https://localhost:44350/api/usuario/");
            var Usuarios = JsonConvert.DeserializeObject<ApiResponse<List<Usuarios>>>(json);
            var _Usuario = Usuarios.Data.FirstOrDefault(e => e.NombreUsuario.Equals(login.NombreUsuario) && e.Contrasenia.Equals(login.Contrasenia));
            if (_Usuario != null && _Usuario.Tipo == "Admin")
            {
                HttpContext.Session.SetInt32("id", _Usuario.Id);
                HttpContext.Session.SetString("tipo", _Usuario.Tipo);
                route = "IndexAdministracion";
            }
            else if (_Usuario != null && _Usuario.Tipo == "Cliente")
            {
                HttpContext.Session.SetInt32("id", _Usuario.Id);
                HttpContext.Session.SetString("tipo", _Usuario.Tipo);
              
                var jsonRestau = await client.GetStringAsync("https://localhost:44350/api/restaurante");
                var listRestau = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Restaurantes>>>(jsonRestau);
                try
                {
                    var restaurante = listRestau.Data.Last(e => e.IdUsuarioR == _Usuario.Id);
                    HttpContext.Session.SetInt32("miRest", restaurante.Id);
                }
                catch
                {
                    HttpContext.Session.SetInt32("miRest", 0);
                }                   
                route = "IndexCliente";
            }
            else
                route = "Index";

            return RedirectToAction(route);
        }

        public async Task<IActionResult> IndexAdministracion()
        {
            if (HttpContext.Session.GetString("id") != null && HttpContext.Session.GetString("tipo") == "Admin")
            {
                int id = (int)HttpContext.Session.GetInt32("id");
                var json = await client.GetStringAsync("https://localhost:44350/api/usuario/" + id);
                var usuario = JsonConvert.DeserializeObject<ApiResponse<Usuarios>>(json);
                return View(usuario.Data);
            }
            else
                return RedirectToAction("Index");            
        }

        public async Task<IActionResult> IndexCliente()
        {
            if (HttpContext.Session.GetString("id") != null && HttpContext.Session.GetString("tipo") == "Cliente")
            {
                int id = (int)HttpContext.Session.GetInt32("id");
                var json = await client.GetStringAsync("https://localhost:44350/api/usuario/" + id);
                var usuario = JsonConvert.DeserializeObject<ApiResponse<Usuarios>>(json);
                return View(usuario.Data);
            }            
            else            
                return RedirectToAction("Index");            
        }

        public IActionResult LogOut()
        {
            HttpContext.Session.Remove("id");
            HttpContext.Session.Remove("tipo");
            return RedirectToAction("Index");
        }

 
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
