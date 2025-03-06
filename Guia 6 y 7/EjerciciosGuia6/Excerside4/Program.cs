internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("Estructuras de control repetitivas");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();  
        Console.Clear();
        Console.WriteLine("Factorial de un número");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Ingrese un número entero: ");
        int number1 = 0;
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {number1}");
        Console.WriteLine("-----------------------------------------------------------");
        int factorial = 1;
        for (int i = 1; i <= number1; i++)
        {
            factorial *= i;
        }
        Console.WriteLine($"El factorial de {number1} es: {factorial}");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}