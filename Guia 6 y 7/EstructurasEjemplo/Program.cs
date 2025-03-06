class Program
{
    static void Main(string[] args)
    {
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.Clear();
        Console.WriteLine("Estructuras de control condicionales");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Selectiva simple");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Alternativa simple: if");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Ingrese un número entero: ");
        int num = 0;
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {num}");
        Console.WriteLine("-----------------------------------------------------------");
        if (num > 0)
        {
            Console.WriteLine("El número es mayor que cero");
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Alternativa doble: if-else");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Ingrese un número entero: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {num}");
        Console.WriteLine("-----------------------------------------------------------");
        if (num > 0)
        {
            Console.WriteLine("El número es mayor que cero");
        }
        else
        {
            Console.WriteLine("El número es menor o igual a cero");
        }
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Alternativa múltiple: Switch");
        Console.WriteLine("-----------------------------------------------------------");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Ingrese un número del 1 al 5: ");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numero ingresado: {num}");
        Console.WriteLine("-----------------------------------------------------------");
        switch (num)
        {
            case 1:
                Console.WriteLine("El número ingresado es el 1");
                break;
            case 2:
                Console.WriteLine("El número ingresado es el 2");
                break;
            case 3:
                Console.WriteLine("El número ingresado es el 3");
                break;
            case 4:
                Console.WriteLine("El número ingresado es el 4");
                break;
            case 5:
                Console.WriteLine("El número ingresado es el 5");
                break;
            default:
                Console.WriteLine("El número ingresado no está en el rango de 1 a 5");
                break;
        }
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
        Console.Clear();
        Console.ForegroundColor = color;
    }
}