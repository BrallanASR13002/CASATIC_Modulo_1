internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Valor maximo de un arreglo de numeros enteros");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Ingrese la cantidad de elementos del arreglo: ");
        int n = int.Parse(Console.ReadLine());
        int[] arreglo = new int[n];
        int max = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Ingrese el elemento {0} del arreglo: ", i + 1);
            arreglo[i] = int.Parse(Console.ReadLine());
            if (arreglo[i] > max)
            {
                max = arreglo[i];
            }
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("El arreglo ingresado es: ");
        for (int i = 0; i < n; i++)
        {
            Console.Write(arreglo[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("El valor maximo del arreglo es: {0}", max);
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}