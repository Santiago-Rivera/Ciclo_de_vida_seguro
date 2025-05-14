using System;

namespace Variables
{
    internal static class Variables
    {
        static void Main(string[] args)
        {    
            // Declaración de variables

            var name = "Juan"; //Declaración de variable de tipo string

            int age = 30; //Declaración de variable de tipo int

            double height = 1.75; //Declaración de variable de tipo double

            Console.WriteLine(name + " tiene " + age + " años y mide " + height + " metros."); //Concatenación de cadenas

            // Costantes

            const double PI = 3.14159; //Declaración de constante de tipo double

            const string GREETING = "Hola"; //Declaración de constante de tipo string

            Console.WriteLine(GREETING + ", el valor de PI es " + PI); //Concatenación de cadenas

            // Tipos de datos

            bool isTrue = true; //Declaración de variable de tipo bool

            char letter = 'A'; //Declaración de variable de tipo char

            string text = "Hola Mundo"; //Declaración de variable de tipo string

            int number = 42; //Declaración de variable de tipo int

            double decimalNumber = 3.14; //Declaración de variable de tipo double

            Console.WriteLine("El valor booleano es: " + isTrue); //Impresión de variable de tipo bool
            
            Console.WriteLine("La letra es: " + letter); //Impresión de variable de tipo char
            
            Console.WriteLine("El texto es: " + text); //Impresión de variable de tipo string
            
            Console.WriteLine("El número entero es: " + number); //Impresión de variable de tipo int

            Console.WriteLine("El número decimal es: " + decimalNumber); //Impresión de variable de tipo double
        }
    }
}