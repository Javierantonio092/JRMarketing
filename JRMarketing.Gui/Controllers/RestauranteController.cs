﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using JRMarketing.Gui.Models;
using JRMarketing.Gui.Responses;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace JRMarketing.Gui.Controllers
{
    public class RestauranteController : Controller
    {
        HttpClient httpClient = new HttpClient();

        public RestauranteController()
        { }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("id") != null && HttpContext.Session.GetString("tipo") == "Admin")
            {                
                var json = await httpClient.GetStringAsync("https://localhost:44350/api/restaurante");
                var listRestaurantes = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Restaurantes>>>(json);
                var restaurantes = listRestaurantes.Data;
                return View(restaurantes);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                var json = await httpClient.GetStringAsync("https://localhost:44350/api/restaurante/" + id);
                var restaurante = JsonConvert.DeserializeObject<ApiResponse<Restaurantes>>(json);
                return View(restaurante.Data);
            }
            else
                return RedirectToAction("Index", "Home");
        }
      
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("id") != null)
                return View();
            else
                return RedirectToAction("Index", "Home");
        }
        [HttpPost]
        public async Task<IActionResult> Create(RestaurantesRequestDto restaurante)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                string imagen = UploadImage(restaurante);
                restaurante.FotografiaR = imagen;
                var json = await httpClient.PostAsJsonAsync("https://localhost:44350/api/restaurante/", restaurante);
                if (json.IsSuccessStatusCode)
                {
                    if (HttpContext.Session.GetString("tipo") == "Admin")
                        return RedirectToAction("IndexAdministracion", "Home");
                    else
                    {
                        var jsonRestau = await httpClient.GetStringAsync("https://localhost:44350/api/restaurante");
                        var listRestau = JsonConvert.DeserializeObject<ApiResponse<IEnumerable<Restaurantes>>>(jsonRestau);
                        var miId = (int)HttpContext.Session.GetInt32("id");
                        var myrestaurante = listRestau.Data.First(e => e.IdUsuarioR == miId);                       
                        HttpContext.Session.SetInt32("miRest", myrestaurante.Id);
                        return RedirectToAction("IndexCliente", "Home");
                    }                        
                }
                else
                    return View(restaurante);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        private string UploadImage(RestaurantesRequestDto imagen)
        {
            string fileName = null, filePath = null;
            if (imagen.file != null)
            {
                string path = "C:/Users/Javier Hernández/Documents/Universidad/4° Cuatrimestre/Proyecto Integrador/myimages/";
                fileName = Guid.NewGuid().ToString() + "-" + imagen.file.FileName;
                filePath = Path.Combine(path, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imagen.file.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        private string UpdateImage(Restaurantes imagen)
        {
            string fileName = null, filePath = null;
            if (imagen.file != null)
            {
                string path = "C:/Users/Javier Hernández/Documents/Universidad/4° Cuatrimestre/Proyecto Integrador/myimages/";
                fileName = Guid.NewGuid().ToString() + "-" + imagen.file.FileName;
                filePath = Path.Combine(path, fileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imagen.file.CopyTo(fileStream);
                }
            }
            return fileName;
        }

        public async Task<IActionResult> Update(int id)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {                
                if(HttpContext.Session.GetString("tipo") == "Admin")
                {
                    var json = await httpClient.GetStringAsync("https://localhost:44350/api/restaurante/" + id);
                    var restaurante = JsonConvert.DeserializeObject<ApiResponse<Restaurantes>>(json);
                    return View(restaurante.Data);
                }
                else
                {
                    var rest = (int)HttpContext.Session.GetInt32("miRest");
                    var json = await httpClient.GetStringAsync("https://localhost:44350/api/restaurante/" + id);
                    var restaurante = JsonConvert.DeserializeObject<ApiResponse<Restaurantes>>(json);
                    try
                    {                       
                        return View(restaurante.Data);
                    }
                    catch
                    {
                        return RedirectToAction("Create");
                    }                       
                }
            }
            else
                return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Update(Restaurantes restaurante)
        {
            if (HttpContext.Session.GetInt32("id") != null)
            {
                if(restaurante.file != null)
                {
                    var image = UpdateImage(restaurante);
                    restaurante.FotografiaR = image;
                }                
                httpClient.BaseAddress = new Uri("https://localhost:44350/api/restaurante/");
                var putTask = httpClient.PutAsJsonAsync<Restaurantes>("?id=" + restaurante.Id, restaurante);
                putTask.Wait();

                var result = putTask.Result;
                if (!result.IsSuccessStatusCode)
                {
                    ViewData["Message"] = "Error";
                }
                else if (result.IsSuccessStatusCode)
                {
                    return View(restaurante);
                }
                return View(restaurante);
            }
            else
                return RedirectToAction("Index", "Home");
        }
               

    }
}
;