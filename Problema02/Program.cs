
using System.Globalization;

Console.Write("Ingrese el peso del paquete en kg: ");

double peso = double.Parse(
    Console.ReadLine()!.Replace(',', '.'),
    CultureInfo.InvariantCulture);

int tarifa;

if (peso <= 0)
{
    tarifa = 0;
    Console.WriteLine("Peso inválido");
}
else if (peso < 1)
{
    tarifa = 8000;
}
else if (peso < 5)
{
    tarifa = 15000;
}
else if (peso < 20)
{
    tarifa = 32000;
}
else
{
    tarifa = 60000;
}

if (peso > 0)
{
    Console.WriteLine($"Tarifa: ${tarifa:N0}");
}
