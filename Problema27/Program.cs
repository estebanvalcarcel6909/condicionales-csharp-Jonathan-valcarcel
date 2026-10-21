
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el día de la semana: ");
        string dia = Console.ReadLine()!.Trim().ToLower();

        Console.Write("¿Es estudiante? (si/no): ");
        string respuesta = Console.ReadLine()!.Trim().ToLower();

        bool estudiante = respuesta == "si" || respuesta == "sí";
        int tarifa;

        if (dia == "martes")
        {
            tarifa = 7000;
        }
        else if (dia == "sábado" || dia == "sabado" ||
                 dia == "domingo")
        {
            tarifa = 15000;
        }
        else if (dia == "lunes" || dia == "miércoles" ||
                 dia == "miercoles" || dia == "jueves" ||
                 dia == "viernes")
        {
            tarifa = estudiante ? 9000 : 12000;
        }
        else
        {
            Console.WriteLine("Día inválido");
            return;
        }

        Console.WriteLine($"Precio de la boleta: ${tarifa:N0}");
    }
}
