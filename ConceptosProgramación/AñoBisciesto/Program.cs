do
{
    Console.WriteLine("Ingrese el año: ");
    int año = int.Parse(Console.ReadLine());

    if (año % 4 == 0 && año % 100 != 0 || año % 400 == 0)
    {
        Console.WriteLine($"el año: {año},  es bisiesto");
    }
    else
    {
        Console.WriteLine($"el año: {año}, no es bisiesto");
    }
    Console.WriteLine("¿Desea continuar? (s/n): ");
    string respuesta = Console.ReadLine();
    if (respuesta.ToLower() != "s")
    {
        break;
    }
}
while (true);