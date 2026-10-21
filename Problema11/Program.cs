
using System;

enum EstadoSemaforo
{
    Rojo,
    Amarillo,
    Verde
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el estado (Rojo, Amarillo, Verde): ");
        string entrada = Console.ReadLine()!;

        if (Enum.TryParse(entrada, true, out EstadoSemaforo estado)
            && Enum.IsDefined(typeof(EstadoSemaforo), estado))
        {
            switch (estado)
            {
                case EstadoSemaforo.Rojo:
                    Console.WriteLine("Deténgase");
                    break;

                case EstadoSemaforo.Amarillo:
                    Console.WriteLine("Precaución, prepárese para detenerse");
                    break;

                case EstadoSemaforo.Verde:
                    Console.WriteLine("Avance");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Estado no válido");
        }
    }
}
