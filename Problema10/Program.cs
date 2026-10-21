
using System;

class Program
{
    static void Main()
    {
        object dato = "SENA";

        switch (dato)
        {
            case string texto:
                Console.WriteLine(
                    $"Texto de {texto.Length} caracteres");
                break;

            case int entero:
                Console.WriteLine($"Entero: {entero}");
                break;

            case double decimalDato:
                Console.WriteLine($"Decimal: {decimalDato}");
                break;

            case bool booleano:
                Console.WriteLine($"Booleano: {booleano}");
                break;

            default:
                Console.WriteLine("Tipo no reconocido");
                break;
        }
    }
}
