class Program
{
    static void Main(string[] args)
    {
    Console.WriteLine("Ejemplo de operadores aritméticos, logicos y relacionales");
    Console.WriteLine("-----------------------------------------------------------");
    Console.WriteLine("Ingrese el primer número: ");
    int num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Ingrese el segundo número: ");
    int num2 = int.Parse(Console.ReadLine());
    Console.WriteLine("Operadores aritméticos");
    Console.WriteLine($"Suma de {num1} y {num2}: " + (num1 + num2));
    Console.WriteLine($"Resta de {num1} y {num2}: " + (num1 - num2));
    Console.WriteLine($"Multiplicación de {num1} y {num2}: " + (num1 * num2));
    Console.WriteLine($"División de {num1} y {num2}: " + (num1 / num2));
    Console.WriteLine($"Módulo de {num1} y {num2}: " + (num1 % num2));
    Console.WriteLine("Operadores relacionales");
    Console.WriteLine($"Igualdad entre {num1} y {num2}: " + (num1 == num2));    
    Console.WriteLine($"Diferencia entre {num1} y {num2}: " + (num1 != num2));
    Console.WriteLine($"Es {num1} mayor que {num2}: " + (num1 > num2));
    Console.WriteLine($"Es {num1} menor que {num2}: " + (num1 < num2));
    Console.WriteLine($"Es {num1} mayor o igual que {num2}: " + (num1 >= num2));
    Console.WriteLine($"Es {num1} menor o igual que {num2}: " + (num1 <= num2));
    Console.WriteLine("Operadores lógicos");
    Console.WriteLine($"Es {num1} > 0 AND {num2} > 0?: " + (num1 > 0 && num2 > 0));
    Console.WriteLine($"Es {num1} >0 OR {num2}: >0?: " + (num1 > 0 || num2 > 0));
    Console.WriteLine($"Uso de NOT: ");
    Console.WriteLine($"!({num1}>0)"+!(num1 > 0));
    Console.ReadKey();

    }
}
