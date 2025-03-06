ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Clear();
Console.WriteLine("Ejercicio de arreglos");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese el tamaño del arreglo: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Ingrese el valor para la posición {i}: ");
    numbers[i] = int.Parse(Console.ReadLine());
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Los valores ingresados son: ");
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Posición {i}: {numbers[i]}");
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("La suma de los números dentro del arreglo es: ");
int sum = 0;
for (int i = 0; i < size; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("valor maximo del arreglo");
Console.WriteLine("-----------------------------------------------------------");
int max = numbers[0];
for (int i = 1; i < size; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}
Console.WriteLine($"El valor máximo del arreglo es: {max}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.ForegroundColor = color;