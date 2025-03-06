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
        Console.WriteLine("Repetitiva condicional: for");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Conteo del 1 al 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine("iteración: "+i);
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}