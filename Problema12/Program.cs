
using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Tiene empleo? (si/no): ");
        string respuesta = Console.ReadLine()!.Trim().ToLower();

        if (respuesta == "si" || respuesta == "sí")
        {
            Console.Write("Ingrese su ingreso mensual: ");
            decimal ingreso = decimal.Parse(Console.ReadLine()!);

            if (ingreso >= 2500000)
            {
                Console.WriteLine("Crédito alto aprobado");
            }
            else
            {
                Console.WriteLine("Crédito básico aprobado");
            }
        }
        else
        {
            Console.WriteLine("Crédito rechazado");
        }
    }
}
