internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Conteo de caracteres en una cadena de texto");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Ingrese una cadena de texto: ");
        string texto = Console.ReadLine();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Texto ingresado: " + texto);
        Console.WriteLine("Cantidad de caracteres: " + texto.Length);
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}