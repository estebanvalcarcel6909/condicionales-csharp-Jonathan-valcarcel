
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el primer número entero: ");
        int num1 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el segundo número entero: ");
        int num2 = int.Parse(Console.ReadLine()!);

        Console.Write("Ingrese el operador (+, -, *, /): ");
        char operador = char.Parse(Console.ReadLine()!);

        try
        {
            double resultado;

            switch (operador)
            {
                case '+':
                    resultado = num1 + num2;
                    break;

                case '-':
                    resultado = num1 - num2;
                    break;

                case '*':
                    resultado = num1 * num2;
                    break;

                case '/':
                    if (num2 == 0)
                    {
                        throw new DivideByZeroException(
                            "No se puede dividir entre cero");
                    }

                    resultado = (double)num1 / num2;
                    break;

                default:
                    throw new NotSupportedException(
                        "Operador no soportado");
            }

            Console.WriteLine(
                $"{num1} {operador} {num2} = {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotSupportedException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
