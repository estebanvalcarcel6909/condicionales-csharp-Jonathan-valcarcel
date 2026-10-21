
using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el código del país: ");
        string codigo = Console.ReadLine()!.Trim().ToUpper();

        string pais;

        switch (codigo)
        {
            case "CO":
                pais = "Colombia";
                break;

            case "MX":
                pais = "México";
                break;

            case "AR":
                pais = "Argentina";
                break;

            case "PE":
                pais = "Perú";
                break;

            case "CL":
                pais = "Chile";
                break;

            default:
                pais = "País no registrado";
                break;
        }

        Console.WriteLine(pais);
    }
}
