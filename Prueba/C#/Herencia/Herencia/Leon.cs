using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Leon: Mascota
    {
        public Leon(string nombre, string tipo, string raza, int edad, string color) : base(nombre, tipo, raza, edad, color)
        {
        }
        public void Rugir()
        {
            Console.WriteLine("El león está rugiendo");
        }

        public void Cazar()
        {
            Console.WriteLine("El león está cazando");
        }
    }
}
