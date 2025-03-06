// See https://aka.ms/new-console-template for more information
ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Clear();
Console.WriteLine("Estructuras anidadas");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear(); Console.WriteLine("Estructura while");
Console.WriteLine("-----------------------------------------------------------");
int countValue = 0;
Console.WriteLine($"Valor del contador {countValue}");
Console.WriteLine("-----------------------------------------------------------");
while (countValue < 5)
{
    Console.WriteLine("El valor del contador es: " + countValue);
    countValue++;
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("\nEstrucrtura do-while");
int countValueDoWhile = 0;
Console.WriteLine($"Valor del contador {countValueDoWhile}");
Console.WriteLine("-----------------------------------------------------------");
do
{

    Console.WriteLine("El valor del contador es: " + countValueDoWhile);
    countValueDoWhile++;

} while (countValueDoWhile < 5);
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("\nEstrucrtura for para un contador");
Console.WriteLine("-----------------------------------------------------------");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("El valor del contador es: " + i);
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("\nEstrucrtura for para un arreglo");
Console.WriteLine("-----------------------------------------------------------");
int[] numeros = { 1, 2, 3 };
for (int j = 0; j <= numeros.Length; j++)

{

    Console.WriteLine("El valor del contador es: " + j);
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.ForegroundColor = color;
