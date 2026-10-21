
using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese la primera nota (0-100): ");
        double nota1 = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la segunda nota (0-100): ");
        double nota2 = double.Parse(Console.ReadLine()!);

        Console.Write("Ingrese la tercera nota (0-100): ");
        double nota3 = double.Parse(Console.ReadLine()!);

        if (nota1 < 0 || nota1 > 100 ||
            nota2 < 0 || nota2 > 100 ||
            nota3 < 0 || nota3 > 100)
        {
            Console.WriteLine("Nota inválida");
            return;
        }

        double promedio = (nota1 + nota2 + nota3) / 3;
        char letra;
        string retroalimentacion;

        if (promedio >= 90)
        {
            letra = 'A';
        }
        else if (promedio >= 80)
        {
            letra = 'B';
        }
        else if (promedio >= 70)
        {
            letra = 'C';
        }
        else if (promedio >= 60)
        {
            letra = 'D';
        }
        else
        {
            letra = 'F';
        }

        switch (letra)
        {
            case 'A':
                retroalimentacion = "Desempeño excelente";
                break;

            case 'B':
            case 'C':
                retroalimentacion = "Buen desempeño, sigue así";
                break;

            case 'D':
                retroalimentacion = "Aprobado, refuerza los temas";
                break;

            default:
                retroalimentacion =
                    "Debe presentar plan de mejoramiento";
                break;
        }

        string estado = promedio >= 60 ? "Aprobado" : "Reprobado";

        string promedioTexto = promedio.ToString(
            "F1", CultureInfo.GetCultureInfo("es-CO"));

        Console.WriteLine(
            $"Promedio: {promedioTexto} | Letra: {letra} | " +
            $"{retroalimentacion} | {estado}");

        if (promedio == 100)
        {
            Console.WriteLine("¡Mención de honor!");
        }
    }
}
