do
{
    Console.WriteLine("\nIngresa el primer  número: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingresa el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    if (num1 % num2 == 0)
    {
        Console.WriteLine($"\nEl numero {num2} es múltiplo de {num1}");
    }
    else
    {
        Console.WriteLine($"\nEl numero {num2} no es múltiplo de {num1}");
    }

    Console.WriteLine("\n¿Desea continuar? (s/n): ");
    string respuesta = Console.ReadLine();
    if (respuesta.ToLower() != "s")
    {
        break;
    }
}
while (true);