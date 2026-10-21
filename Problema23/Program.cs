
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el usuario: ");
        string usuario = Console.ReadLine()!;

        if (usuario == "aprendiz")
        {
            Console.Write("Ingrese la contraseña: ");
            string contrasena = Console.ReadLine()!;

            if (contrasena == "Sena2026")
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Contraseña incorrecta");
            }
        }
        else
        {
            Console.WriteLine("Usuario no encontrado");
        }
    }
}
