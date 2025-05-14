using System;


namespace Clases
{
    internal static class Clases
    {
        static void Main()
        {
            // Instancia de la clase Computadora

            Computadora asus = new Computadora();
            asus.Encender();
            asus.Apagar();
            asus.Reiniciar();
            asus.InstalarSoftware("Windows 11");
            asus.DesinstalarSoftware("Windows 11");
            asus.ActualizarSoftware("Windows 11");
            asus.Modelo("VivoBook");
            asus.Procesador("Intel");
            asus.Ram(16);
            asus.Software("Windows");
            asus.AnoDeFabricacion(2024);
        }
    }

    // Definición de la clase Computadora
    
    class Computadora 
    {
        public string marca;
        public int anoDeFabricacion;
        public string modelo;
        public string procesador;
        public int ram;
        public string software;

       public void Encender()
        {
            Console.WriteLine("Encendiendo la computadora...", marca);
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando la computadora...", marca);
        }

        public void Reiniciar()
        {
            Console.WriteLine("Reiniciando la computadora...", marca);
        }

        public void InstalarSoftware(string software)
        {
            Console.WriteLine($"Instalando {software}...", software);
        }

        public void DesinstalarSoftware(string software)
        {
            Console.WriteLine($"Desinstalando {software}...", software);
        }

        public void ActualizarSoftware(string software)
        {
            Console.WriteLine($"Actualizando {software}...", software);
        }

        public void Modelo(string modelo)
        {
            Console.WriteLine($"El modelo de la computadora es: {modelo}", modelo);
        }

        public void Procesador(string procesador)
        {
            Console.WriteLine($"El procesador de la computadora es: {procesador}", procesador);
        }

        public void Ram(int ram)
        {
            Console.WriteLine($"La ram de la computadora es: {ram} GB", ram);
        }

        public void Software(string software)
        {
            Console.WriteLine($"El software de la computadora es: {software}", software);
        }

        public void AnoDeFabricacion(int anoDeFabricacion)
        {
            Console.WriteLine($"El año de fabricación de la computadora es: {anoDeFabricacion}", anoDeFabricacion);
        }
    }
}
