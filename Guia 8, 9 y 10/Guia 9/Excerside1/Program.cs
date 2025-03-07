using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("arreglo de numeros enteros y calcular la suma de los elementos");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Ingrese la cantidad de elementos del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] arreglo = new int[n];
        int suma = 0;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingrese el elemento {0} del arreglo: ", i + 1);
            arreglo[i] = int.Parse(Console.ReadLine());
            suma += arreglo[i];
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("El arreglo ingresado es: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("La suma de los elementos del arreglo es: {0}", suma); 
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}