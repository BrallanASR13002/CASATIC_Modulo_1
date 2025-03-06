internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Hola, Mundo!");
        Console.ForegroundColor = color;
        Console.WriteLine("Presiona cualquier tecla para salir");
        Console.ReadKey();
        Console.Clear();
    }
}