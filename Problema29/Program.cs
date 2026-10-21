
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el rol (admin, instructor, aprendiz): ");
        string rol = Console.ReadLine()!.Trim().ToLower();

        Console.Write("Ingrese la hora de llegada (0-23): ");
        int hora = int.Parse(Console.ReadLine()!);

        bool permitido = false;

        if (hora >= 0 && hora <= 23)
        {
            if (rol == "admin")
            {
                permitido = true;
            }
            else if (rol == "instructor" && hora >= 6 && hora <= 21)
            {
                permitido = true;
            }
            else if (rol == "aprendiz" && hora >= 6 && hora <= 18)
            {
                permitido = true;
            }
        }

        if (permitido)
        {
            Console.WriteLine("Acceso permitido");
        }
        else
        {
            Console.WriteLine("Acceso denegado");
        }
    }
}
