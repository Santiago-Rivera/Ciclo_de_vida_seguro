using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Perro:Mascota
    {
        public Perro(string nombre, string tipo, string raza, int edad, string color) : base(nombre, tipo, raza, edad, color)
        {
        }

        public void Ladrar()
        {
            Console.WriteLine("El perro está ladrando");
        }

        public void Correr()
        {
            Console.WriteLine("El perro está corriendo");
        }


    }
}
