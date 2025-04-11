
Console.WriteLine("Este programa determina el lugar del número, cuál es mayor, medio o el menor: \n");

void OrdenaNume(int num1, int num2, int num3)
{
    int mayor, medio, menor;

    if (num1 >= num2 && num1 >= num3)
    {
        mayor = num1;
        if (num2 > num3)
        {
            medio = num2;
            menor = num3;
        }
        else
        {
            medio = num3;
            menor = num2;
        }
    }
    else if (num2 >= num1 && num2 >= num3)
    {
        mayor = num2;
        if (num1 > num3)
        {
            medio = num1;
            menor = num3;
        }
        else
        {
            medio = num3;
            menor = num1;
        }
    }
    else
    {
        mayor = num3;
        if (num1 > num2)
        {
            medio = num1;
            menor = num2;
        }
        else
        {
            medio = num2;
            menor = num1;
        }
    }

    Console.WriteLine($"\nEl número mayor es: {mayor}");
    Console.WriteLine($"El número medio es: {medio}");
    Console.WriteLine($"El número menor es: {menor}\n");
}

do
{
    Console.WriteLine("Ingresa el primer número: ");
    int num1 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingresa el tercer número: ");
    int num3 = int.Parse(Console.ReadLine());

    OrdenaNume(num1, num2, num3);

    Console.WriteLine("¿Deseas probar con otros números? (s/n): ");
    string respuesta = Console.ReadLine().ToLower();
    if (respuesta != "s")
        break;

} while (true);

