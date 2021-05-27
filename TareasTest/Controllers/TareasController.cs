using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TareasTest.Models;

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TareasTest.Controllers
{
    public class TareasController : Controller
    {
        private static List<Models.Tareas> _tareas;

        // GET: /<controller>/
        public IActionResult Index()
        {
            //InitializeList();
            return View();
        }

        [HttpGet]
        public IActionResult CrearTarea()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CrearTarea(IFormCollection collection)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}
            //return RedirectToAction("TareasAll");
            try
            {
                _tareas.Add(new Models.Tareas()
                {
                    ID = (_tareas.Count == 0) ? 1 : _tareas.Last().ID+1,
                    Titulo = collection["Titulo"],
                    Descripcion = collection["Descripcion"],
                    Encargado = collection["Encargado"],
                });
                return RedirectToAction("TareasAll");
            }
            catch
            {
                return View();

            }
        }
    }
}
