using System;
using System.Security.Cryptography.X509Certificates;


namespace Funciones
{
    internal static class Funciones
    {
        static void Main()
        {
            Console.WriteLine("Ingrese un número para calcular su factorial:");
            int numero = Convert.ToInt32(Console.ReadLine());
            int resultado = Factorial(numero);
            Console.WriteLine($"El factorial de {numero} es {resultado}");
        }
            public static int Factorial(int n)
        {
            if (n == 0 || n == 1)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }
    
}
