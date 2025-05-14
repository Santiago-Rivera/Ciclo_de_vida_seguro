using System;

namespace Herencia
{
    internal class Mascota
    {
        private string nombre;

        private string tipo;

        private string raza;

        private int edad;

        private string color;

        public void Entrenar()
        {
            Console.WriteLine("Entrenando a la mascota");
        }

        public void Alimentar()
        {
            Console.WriteLine("Alimentando a la mascota");
        }

        public Mascota(string nombre, string tipo, string raza, int edad, string color)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.raza = raza;
            this.edad = edad;
            this.color = color;
        }
    }
}
