using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        double number1, number2;
        double result;
        number1=DataInpunt();
        number2=DataInpunt();
        result = number1 + number2;
        Print("El resultado de la suma es: " + result);
    }
    public static double DataInpunt(){
        double number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        number = Convert.ToDouble(data);
        return number;
    }
    public static void Print(string message)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}