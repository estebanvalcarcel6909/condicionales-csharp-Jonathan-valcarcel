
Console.Write("Ingrese el nivel de batería (%): ");
int bateria = int.Parse(Console.ReadLine()!);

if (bateria < 15)
{
    Console.WriteLine("Batería baja: conecte el cargador");
}

Console.WriteLine($"Nivel actual: {bateria} %");
