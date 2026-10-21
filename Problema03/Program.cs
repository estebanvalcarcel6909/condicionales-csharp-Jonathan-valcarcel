
Console.WriteLine("=== CAJERO AUTOMÁTICO ===");
Console.WriteLine("1. Consultar saldo");
Console.WriteLine("2. Retirar");
Console.WriteLine("3. Depositar");
Console.WriteLine("4. Salir");

Console.Write("Seleccione una opción: ");
int opcion = int.Parse(Console.ReadLine()!);

switch (opcion)
{
    case 1:
        Console.WriteLine("Ha seleccionado: Consultar saldo");
        break;

    case 2:
        Console.WriteLine("Ha seleccionado: Retirar");
        break;

    case 3:
        Console.WriteLine("Ha seleccionado: Depositar");
        break;

    case 4:
        Console.WriteLine("Ha seleccionado: Salir");
        break;

    default:
        Console.WriteLine("Opción no válida");
        break;
}
