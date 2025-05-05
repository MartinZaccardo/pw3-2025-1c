using Clase3.MVC.Entidades;
using Clase3.MVC.Servicio;
using Microsoft.AspNetCore.Mvc;

namespace Clase3.MVC.WebApp.Controllers
{
    public class AutosController : Controller
    {
        private IAutoServicio _autoServicio;

        public AutosController(IAutoServicio autoServicio)
        {
            _autoServicio = autoServicio;
        }
        public IActionResult Index()
        {
            return View(_autoServicio.ObtenerAutos());
        }

        [HttpGet]
        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(Auto auto)
        {
            //_autoServicio.AgregarAuto(new Entidades.Auto { Marca = marca, Modelo = modelo});
            /*_autoServicio.AgregarAuto(auto);
            return RedirectToAction("Index");*/
            if (ModelState.IsValid)
            {
                _autoServicio.AgregarAuto(auto);
                return RedirectToAction("Index");
            }

            return View(auto);
        }
    }
}
