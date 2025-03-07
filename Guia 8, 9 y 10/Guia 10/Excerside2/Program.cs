internal class Program
{
    private static void Main(string[] args)
    {
        double radius;
        double result;
        Print("Calculo del area de un circulo, usando funciones");
        radius = DataInpunt();
        result = AreaCircle(radius);
        Print($"El area de un circulo con radio {radius} es: " + result);
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
        public static double AreaCircle(double radius)
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
