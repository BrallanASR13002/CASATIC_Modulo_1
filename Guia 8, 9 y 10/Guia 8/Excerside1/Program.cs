internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Conversión de minusculas a mayusculas y viceversa");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Ingrese una cadena de texto: ");
        string texto = Console.ReadLine();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Texto en mayusculas: " + texto.ToUpper());
        Console.WriteLine("Texto en minusculas: " + texto.ToLower());
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}