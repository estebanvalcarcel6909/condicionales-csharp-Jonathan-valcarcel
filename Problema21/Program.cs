
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la cantidad de artículos: ");
        int cantidad = int.Parse(Console.ReadLine()!);

        string mensaje = $"Tienes {cantidad} artículo" +
            (cantidad == 1 ? "" : "s") +
            " en el carrito";

        Console.WriteLine(mensaje);
    }
}
