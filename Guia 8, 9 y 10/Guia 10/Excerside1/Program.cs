using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double number1, number2;
        double result;
        Print("Suma de dos numeros, usando funciones");
        number1 = DataInpunt();
        number2 = DataInpunt();
        result = number1 + number2;
        Print("El resultado de la suma es: " + result);
    }
    public static double DataInpunt()
    {
        double number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        number = Convert.ToDouble(data);
        return number;
    }
    public static string Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine(message);
        Console.WriteLine("-----------------------------------------------------------");
        Console.ForegroundColor = color;
        return message;
    }
}