do
{
    Console.WriteLine("Digite um número entero:");
    int numero = int.Parse(Console.ReadLine());
    if (numero % 2 == 0)
    {
        Console.WriteLine($"el numero {numero} es par.");
    }
    else
    {
        Console.WriteLine($"el numero {numero} es  impar.");
    }
}
while (true);