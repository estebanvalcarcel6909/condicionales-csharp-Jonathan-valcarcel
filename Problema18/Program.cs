
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la estatura en metros: ");
        double estatura = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la edad: ");
        int edad = int.Parse(Console.ReadLine()!);

        Console.Write("¿Va acompañado por un adulto? (si/no): ");
        string respuesta = Console.ReadLine()!.Trim().ToLower();

        bool acompanado = respuesta == "si" || respuesta == "sí";

        if (estatura >= 1.40 && (edad >= 12 || acompanado))
        {
            Console.WriteLine("Puede subir");
        }
        else
        {
            Console.WriteLine("No puede subir");
        }
    }
}
