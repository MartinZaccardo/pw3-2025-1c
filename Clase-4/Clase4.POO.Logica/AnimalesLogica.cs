using Clase4.POO.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase4.POO.Logica
{
    public interface IAnimalesLogica
    {
        List<IAnimal> ObtenerAnimales();

        void AgregarAnimal(IAnimal animal);
    }

    public class AnimalesLogica : IAnimalesLogica
    {
        public List<IAnimal> Animales { get; set; }

        public AnimalesLogica()
        {
            Animales = new List<IAnimal>();

            // Agregamos equipos de ejemplo
            Animales.Add(new Perro { Nombre = "Pacho" });
            Animales.Add(new Gato { Nombre = "Garfield" });
            Animales.Add(new Vaca { Nombre = "Lola" });
            Animales.Add(new Leon { Nombre = "Simba" });
            Animales.Add(new Gallina { Nombre = "Turuleca" });

        }

        public List<IAnimal> ObtenerAnimales()
        {
            return Animales;
        }

        public void AgregarAnimal(IAnimal animal)
        {
            Animales.Add(animal);
        }



    }
}
