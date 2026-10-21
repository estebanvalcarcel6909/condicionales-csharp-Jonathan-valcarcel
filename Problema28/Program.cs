
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el valor de la compra: ");
        decimal compra = decimal.Parse(Console.ReadLine()!);

        Console.Write("¿Es cliente frecuente? (si/no): ");
        string respuesta = Console.ReadLine()!.Trim().ToLower();

        bool frecuente = respuesta == "si" || respuesta == "sí";
        decimal descuento;

        if (compra < 0)
        {
            Console.WriteLine("Valor de compra inválido");
            return;
        }

        if (compra >= 500000)
        {
            descuento = 15;
        }
        else if (compra >= 200000)
        {
            descuento = 10;
        }
        else if (compra >= 100000)
        {
            descuento = 5;
        }
        else
        {
            descuento = 0;
        }

        if (frecuente && compra >= 100000)
        {
            descuento += 5;
        }

        decimal total = compra * (1 - descuento / 100);

        Console.WriteLine($"Valor de la compra: ${compra:N0}");
        Console.WriteLine($"Descuento total: {descuento}%");
        Console.WriteLine($"Total a pagar: ${total:N0}");
    }
}
