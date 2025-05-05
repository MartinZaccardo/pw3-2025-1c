using Clase3.MVC.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase3.MVC.Servicio
{
    public interface IAutoServicio
    {
        List<Auto> ObtenerAutos();

        void AgregarAuto(Auto auto);

    }

    public class AutoServicio : IAutoServicio
    {
        private static List<Auto> autos { get; set; }

        public AutoServicio()
        {
            if (autos == null)
            {
                autos = new List<Auto>();
                autos.Add(new Auto { Marca = "Ford", Modelo = "Mustang", Foto = "/imagenes/mustang.jpg" });
                autos.Add(new Auto { Marca = "Peugeot", Modelo = "208", Foto = "/imagenes/208.png" });
                autos.Add(new Auto { Marca = "Fiat", Modelo = "Cronos", Foto = "/imagenes/cronos.jpg" });
            }
        }
        public void AgregarAuto(Auto auto)
        {
            autos.Add(auto);
        }

        public List<Auto> ObtenerAutos()
        {
            return autos;
        }
    }
}
