
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el peso en kg: ");
        double peso = double.Parse(
            Console.ReadLine()!,
            CultureInfo.InvariantCulture);

        Console.Write("Ingrese la estatura en metros: ");
        double estatura = double.Parse(
            Console.ReadLine()!,
            CultureInfo.InvariantCulture);

        if (peso <= 0 || estatura <= 0)
        {
            Console.WriteLine("Peso o estatura inválidos");
            return;
        }

        double imc = peso / (estatura * estatura);
        string categoria;

        if (imc < 18.5)
        {
            categoria = "Bajo peso";
        }
        else if (imc < 25)
        {
            categoria = "Peso normal";
        }
        else if (imc < 30)
        {
            categoria = "Sobrepeso";
        }
        else
        {
            categoria = "Obesidad";
        }

        string imcTexto = imc.ToString(
            "F1", CultureInfo.GetCultureInfo("es-CO"));

        Console.WriteLine($"IMC: {imcTexto} - {categoria}");
    }
}
