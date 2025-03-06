internal class Program
{
    private static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("Estructuras de control condicionales");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Selectiva múltiple: switch");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("Ingrese un número entero: ");
        int number1 = 0;
        number1 = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {number1}");
        Console.WriteLine("-----------------------------------------------------------");
        switch (number1)
        {
            case 1:
                Console.WriteLine("El día es lunes");
                break;
            case 2:
                Console.WriteLine("El día es martes");
                break;
            case 3:
                Console.WriteLine("El día es miércoles");
                break;
            case 4:
                Console.WriteLine("El día es jueves");
                break;
            case 5:
                Console.WriteLine("El día es viernes");
                break;
            case 6:
                Console.WriteLine("El día es sábado");
                break;
            case 7:
                Console.WriteLine("El día es domingo");
                break;  
            default:
                Console.WriteLine("El número ingresado no corresponde a un día de la semana");
                break;
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}