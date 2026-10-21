
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número del día (1-7): ");
        int dia = int.Parse(Console.ReadLine()!);

        string resultado;

        if (dia >= 1 && dia <= 5)
        {
            resultado = "Día hábil";
        }
        else if (dia == 6 || dia == 7)
        {
            resultado = "Fin de semana";
        }
        else
        {
            resultado = "Día inválido";
        }

        Console.WriteLine(resultado);
    }
}
