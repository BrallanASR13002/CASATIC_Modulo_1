internal class Program
{
    private static void Main(string[] args)
    {
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
}