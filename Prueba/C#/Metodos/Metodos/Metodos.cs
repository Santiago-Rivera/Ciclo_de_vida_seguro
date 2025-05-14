using System;
using System.Security.Cryptography.X509Certificates;


namespace Métodos
{
    internal static class Métodos
    {
        static void Main()
        {
            Console.WriteLine("Estamos en el método main");

            Mensaje();

            Nombre();

            Console.WriteLine("Ya se ejecuto nuestro método");
        }

        public static void  Mensaje()
        {
            Console.WriteLine("Este es nuestro primer método");
        }

        
        public static string Nombre()
        {
            var nombre = "Juna";

            Console.WriteLine(nombre);

            return "Hola " + nombre;
        }
    }
}
