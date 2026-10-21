
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la categoría del vehículo (M, A, B, C): ");
        char categoria = char.ToUpper(
            char.Parse(Console.ReadLine()!));

        try
        {
            int tarifa;

            switch (categoria)
            {
                case 'M':
                    tarifa = 0;
                    break;

                case 'A':
                    tarifa = 12000;
                    break;

                case 'B':
                    tarifa = 25000;
                    break;

                case 'C':
                    tarifa = 38000;
                    break;

                default:
                    throw new ArgumentException(
                        "Categoría desconocida");
            }

            Console.WriteLine(
                $"Categoría {categoria} - Tarifa: ${tarifa:N0}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
