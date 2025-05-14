using System;


namespace Herencia
{
    internal static class Herencia
    {
        static void Main()
        {
            // Crear una instancia de la clase Perro

            Perro perro = new Perro("Max", "Perro", "Labrador", 5, "Marrón");

            Console.WriteLine(perro);

            // Crear una instancia de la clase Gato

            Gato gato = new Gato("Miau", "Gato", "Siames", 3, "Blanco");

            Console.WriteLine(gato);

            // Crear una instancia de la clase León

            Leon leon = new Leon("Simba", "Leon", "Africano", 7, "Amarillo");

            Console.WriteLine(leon);

            // Llamar a los métodos de la clase Perro

            perro.Ladrar();
            perro.Correr();
            perro.Alimentar();
            perro.Entrenar();

            // Llamar a los métodos de la clase Gato

            gato.Maullar();
            gato.Saltar();
            gato.Alimentar();
            gato.Entrenar();

            // Llamar a los métodos de la clase León

            leon.Rugir();
            leon.Cazar();
            leon.Alimentar();
            leon.Entrenar();
        }
    }
}
