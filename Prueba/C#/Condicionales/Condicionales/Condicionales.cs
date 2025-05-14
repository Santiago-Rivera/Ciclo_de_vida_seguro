using System;

namespace Condicionales
{
    internal static class Condicionales
    {
        static void Main()
        {
            // Condicionales
            // if, else if, else
            // switch
            // Ejemplo de if, else if, else
            int numero = 10;
            if (numero > 0)
            {
                Console.WriteLine("El número es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número es negativo.");
            }
            else
            {
                Console.WriteLine("El número es cero.");
            }

            // Ejemplo de switch

            string dia = "Lunes";
            switch (dia)
            {
                case "Lunes":
                    Console.WriteLine("Hoy es lunes.");
                    break;
                case "Martes":
                    Console.WriteLine("Hoy es martes.");
                    break;
                default:
                    Console.WriteLine("No es lunes ni martes.");
                    break;
            }
        }
    }
}
