using Clase4.POO.Entidades;
using Clase4.POO.Logica;
using Microsoft.AspNetCore.Mvc;

namespace Clase4.POO.Web.Controllers
{
    public class AnimalesController : Controller
    {
        private readonly IAnimalesLogica _animalesLogica;

        public AnimalesController(IAnimalesLogica animalesLogica)
        {
            _animalesLogica = animalesLogica;
        }

        public IActionResult Listar()
        {
            return View(_animalesLogica.ObtenerAnimales());
        }

        [HttpGet]
        public IActionResult AgregarAnimal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AgregarAnimal(string nombre , string tipo)
        {
            IAnimal animal = tipo switch
            {
                "Perro" => new Perro { Nombre = nombre },
                "Gato" => new Gato { Nombre = nombre },
                "Leon" => new Leon { Nombre = nombre },
                "Gallina" => new Gallina { Nombre = nombre },
                "Vaca" => new Vaca { Nombre = nombre }
            };

            if (animal != null)
            {
                _animalesLogica.AgregarAnimal(animal);
                return RedirectToAction("Listar");
            }

            return View();

        }

    }
}
