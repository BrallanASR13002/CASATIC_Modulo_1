internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Comparación de valores");
        Console.WriteLine("Ingrese el primer valor:");
        int valor1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Ingrese el segundo valor:");
        int valor2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Comparando los valores:");
        Console.WriteLine("Mayor que:");
        _ = valor1 > valor2;
        Console.WriteLine("El primer valor es mayor que el segundo");
        Console.WriteLine("Menor que:");
        _ = valor1 < valor2;
        Console.WriteLine("El primer valor es menor que el segundo");
        Console.WriteLine("Mayor o igual que:");
        _ = valor1 >= valor2;
        Console.WriteLine("El primer valor es mayor o igual que el segundo");
        Console.WriteLine("Menor o igual que:");
        _ = valor1 <= valor2;
        Console.WriteLine("El primer valor es menor o igual que el segundo");
        Console.WriteLine("Igual que:");
        _ = valor1 == valor2;
        Console.WriteLine("Los valores son iguales");
        Console.WriteLine("Distinto que:");
        _ = valor1 != valor2;
        Console.WriteLine("Los valores son distintos");
        Console.ForegroundColor = color;
        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();
        Console.Clear();
    }
}