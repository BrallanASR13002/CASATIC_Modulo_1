internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Basic Calculator");
        Console.WriteLine("----------------");
        Console.WriteLine("Enter the first number:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Sum of {num1} and {num2}: " + (num1 + num2));
        Console.WriteLine($"Subtraction of {num1} and {num2}: " + (num1 - num2));
        Console.WriteLine($"Multiplication between {num1} and {num2}: " + (num1 * num2));
        double Division = num1 / num2;
        Console.WriteLine($"Division of {num1} between {num2}: " + Math.Round(Division, 2));
        Console.ForegroundColor = color;
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
        Console.Clear();

    }
}