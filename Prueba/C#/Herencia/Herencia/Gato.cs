using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Gato: Mascota
    {
        public Gato(string nombre, string tipo, string raza, int edad, string color) : base(nombre, tipo, raza, edad, color)
        {
        }
        public void Maullar()
        {
            Console.WriteLine("El gato está maullando");
        }

        public void Saltar()
        {
            Console.WriteLine("El gato está saltando");
        }


    }
}
