using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        
    }
    public double DataInpunt(){
        double number;
        string data;
        Print("Ingrese un numero: ");
        data = Console.ReadLine();
        number = Convert.ToDouble(data);
        return number;
    }
    public void Print(string message)
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
    public double Sum(double number1, double number2)
    {
        return number1 + number2;
    }
}