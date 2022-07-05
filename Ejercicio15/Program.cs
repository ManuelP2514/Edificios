using System;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double Pisos, AlturaDeCadaPiso, AlturaEdificio;
            Console.WriteLine("Ingrese la cantidad de Pisos ");
            Pisos = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la altura de cada Piso ");
            AlturaDeCadaPiso = double.Parse(Console.ReadLine());
            AlturaEdificio = (Pisos * AlturaDeCadaPiso);
            Console.WriteLine($"La Altura Del Edificio Es De {AlturaEdificio} Metros");
        }
    }
}
