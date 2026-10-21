
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese una letra minúscula: ");
        string entrada = Console.ReadLine()!;

        if (entrada.Length != 1)
        {
            Console.WriteLine("No es una letra");
            return;
        }

        char letra = entrada[0];

        if (letra < 'a' || letra > 'z')
        {
            Console.WriteLine("No es una letra");
        }
        else if ("aeiou".Contains(letra))
        {
            Console.WriteLine("Es vocal");
        }
        else
        {
            Console.WriteLine("Es consonante");
        }
    }
}
