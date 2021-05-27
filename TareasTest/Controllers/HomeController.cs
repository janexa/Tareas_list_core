using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TareasTest.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace TareasTest.Controllers
{
    public class HomeController : Controller
    {
        private static List<Models.Tareas> _tareas;

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CrearTarea(Tareas tareas)
        {
            return View();
            //return RedirectToAction("CrearTarea");
        }

        //[HttpGet]
        //public IActionResult EditarTarea(Tareas tareas)
        //{
        //    return View();
        //}


        public IActionResult Create()
        {
            return RedirectToAction("CrearTarea");
        }

        public IActionResult Editar()
        {
            return RedirectToAction("EditarTarea");
        }

        //[BindProperty]
        //public Usuario Usuario { get; set; }

        //public IActionResult SetUsuario()
        //{
        //    //return Json(Usuario);

        //    return Redirect("/Home/Privacy");
        //}

        [HttpPost]
        public IActionResult Index(Usuario user)
        {


            if (!ModelState.IsValid)
            {
                return View();
            }

            //return RedirectToAction("Privacy");
            return RedirectToAction("TareasAll");
        }

        public IActionResult Privacy()
        {
            ViewData["ID"] = "1";
            ViewBag.Titulo = "Soporte Infra";
            ViewData["Encargado"] = "Jose Duran";
            TempData["Descripcion"] = "Realizar el soporte de primer piso";
            List<string> TareasPendientes = new List<string>
            {
                "ID","Titulo","Encargado","Descripcion"
            };
            ViewData["TareasPendientes"] = TareasPendientes;
            ViewBag.TareasPendientes = TareasPendientes;
            TempData["TareasPendientes"] = TareasPendientes;
            return View();
        }

        public IActionResult TareasAll()
        {
            if (_tareas== null)
            {
                _tareas = new List<Tareas>();
            }

            return View(_tareas);
        }


        public IActionResult CrearTarea()
        {
            ViewData["ID"] = "1";
            ViewBag.Titulo = "Soporte Infra";
            ViewData["Encargado"] = "Jose Duran";
            TempData["Descripcion"] = "Realizar el soporte de primer piso";
            List<string> TareasPendientes = new List<string>
            {
                "ID","Titulo","Encargado","Descripcion"
            };
            ViewData["TareasPendientes"] = TareasPendientes;
            ViewBag.TareasPendientes = TareasPendientes;
            TempData["TareasPendientes"] = TareasPendientes;
            return View();
        }

        [HttpPost]
        public ActionResult CrearTarea(IFormCollection collection)
        {
            try
            {
                _tareas.Add(new Models.Tareas()
                {
                    ID = (_tareas.Count == 0) ? 1 : _tareas.Last().ID + 1,
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



        [HttpGet]
        public ActionResult EditarTarea(int id)
        {
            //_tareas.Find(item => item.ID == id);

            try
            {
                var std = _tareas.Find(item => item.ID == id);

                return View(std);
            }
            catch
            {
                return View();

            }
        }

        [HttpPost]
        public ActionResult EditarTarea(Models.Tareas TaskObj)
        {
            try
            {
                Models.Tareas ViewModel = _tareas.FirstOrDefault(x => x.ID == TaskObj.ID);
                ViewModel.Titulo = TaskObj.Titulo;
                ViewModel.Descripcion = TaskObj.Descripcion;
                ViewModel.Encargado = TaskObj.Encargado;

                return View(nameof(TareasAll), _tareas);
            }
            catch
            {
                return View(nameof(TareasAll), _tareas);

            }
        }

        [HttpGet]
        public ActionResult EliminarTarea(int id)
        {


            try
            {
                var std = _tareas.Find(item => item.ID == id);

                return View(std);
            }
            catch
            {
                return View();

            }
        }

        [HttpPost]
        public ActionResult EliminarTarea(Models.Tareas TaskObj)
        {
            try
            {
               Tareas TareaAEliminar = _tareas.FirstOrDefault(x => x.ID == TaskObj.ID);
                if (TareaAEliminar != null)
                {
                    //_tareas.Remove(TareaAEliminar);
                    _tareas.RemoveAt(TaskObj.ID);

                }

                return View(nameof(TareasAll), _tareas);
            }
            catch
            {
                return View(nameof(TareasAll), _tareas);

            }
        }


        // GET: Default1/Delete/5
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                //Tareas TareaAEliminar = _tareas.FirstOrDefault(x => x.ID == id);
                Tareas TareaAEliminar = _tareas.Find(item => item.ID == id);
                if (TareaAEliminar != null)
                {
                    _tareas.RemoveAt(id);
                }
                _tareas.RemoveAt(id);
                return RedirectToAction(nameof(TareasAll));
            }
            catch
            {
                return View();
            }
        }



        //public ActionResult Delete(Models.Tareas TaskObj)
        //{

        //    try
        //    {
        //        Tareas TareaAEliminar = _tareas.FirstOrDefault(x => x.ID == TaskObj.ID);
        //        if (TareaAEliminar != null)
        //        {
        //            _tareas.RemoveAt(TaskObj.ID);
        //        }

        //        return View(nameof(TareasAll), _tareas);
        //    }
        //    catch
        //    {
        //        return View(nameof(TareasAll), _tareas);

        //    }
        //}

        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult EliminarTarea(Models.Tareas TaskObj)
        //{
        //    try
        //    {
        //        Tareas TareaAEliminar = _tareas.FirstOrDefault(x => x.ID == TaskObj.ID);
        //        if (TareaAEliminar != null)
        //        {
        //            _tareas.Remove(TareaAEliminar);
        //        }

        //        return View(nameof(TareasAll), _tareas);
        //    }
        //    catch
        //    {
        //        return View(nameof(TareasAll), _tareas);

        //    }
        //}




        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
