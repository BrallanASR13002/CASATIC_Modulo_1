class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ejemplo de configuración");
        Console.WriteLine("Presione una tecla para continuar...");
        Console.ReadKey();
        Console.WriteLine("Verificando si una persona puede usar un vehículo");
        bool isAdult = true;
        bool canDrive = false;
        bool result = isAdult && canDrive;
        Console.WriteLine("Puede tener un auto: " + result);
        Console.WriteLine("Ejemplo de disyunción");
        Console.WriteLine("Verificando si una persona puede votar en elecciones");
        result = isAdult || canDrive;
        Console.WriteLine("Puede votar: " + result);
        Console.WriteLine("Ejemplo de negación");
        Console.WriteLine("Negando que una persona sea adulta");
        result = !isAdult;
        Console.WriteLine("La persona es adulta: " + result); 
        Console.WriteLine("Presione una tecla para salir...");
        Console.ReadKey();
    }
}