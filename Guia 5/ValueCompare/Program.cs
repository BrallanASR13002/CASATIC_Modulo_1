internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Comparación de valores");
        Console.WriteLine("Ingrese el primer valor:");
        string valor1 = Console.ReadLine();
        Console.WriteLine("Ingrese el segundo valor:");
        string valor2 = Console.ReadLine();
        Console.WriteLine("Mayor que:");
        valor1 > valor2 ? Console.WriteLine("El primer valor es mayor que el segundo") : Console.WriteLine("El segundo valor es mayor que el primero");
        Console.WriteLine("Menor que:");
        valor1 < valor2 ? Console.WriteLine("El primer valor es menor que el segundo") : Console.WriteLine("El segundo valor es menor que el primero");
        Console.WriteLine("Igual que:");
        valor1 == valor2 ? Console.WriteLine("Los valores son iguales") : Console.WriteLine("Los valores son diferentes");
        Console.WriteLine("Distinto que:");
        valor1 != valor2 ? Console.WriteLine("Los valores son diferentes") : Console.WriteLine("Los valores son iguales");
        Console.ForegroundColor = color;
        Console.WriteLine("Presione una tecla para salir");
        Console.ReadKey();
        Console.Clear();
    }
}