
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el número del mes (1-12): ");
        int mes = int.Parse(Console.ReadLine()!);

        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Console.WriteLine("31 días");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Console.WriteLine("30 días");
                break;

            case 2:
                Console.WriteLine("28 días");
                break;

            default:
                Console.WriteLine("Mes inválido");
                break;
        }
    }
}
