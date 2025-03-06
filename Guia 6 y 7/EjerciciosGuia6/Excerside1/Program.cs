internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("Estructuras de control condicionales");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Selectiva simple");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("Alternativa simple: if");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("Ingrese un número entero: ");
        int number1 = 0;
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {number1}");
        Console.WriteLine("-----------------------------------------------------------");
        if (number1 > 0)
        {
            Console.WriteLine("El número es mayor que cero");
        }else if (number1 == 0)
        {
            Console.WriteLine("El número es igual a cero");
        }
        else
        {
            Console.WriteLine("El número es menor que cero");
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}