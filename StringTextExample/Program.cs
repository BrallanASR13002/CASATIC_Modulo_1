ConsoleColor color = Console.ForegroundColor;
Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.Clear();
Console.WriteLine("Ejemplo de cadena de texto");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese un caracter: ");
char caracter = char.Parse(Console.ReadLine());
Console.WriteLine($"Caracter ingresado: {caracter}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Conversión a codigo ASCII");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine($"El código ASCII del caracter {caracter} es: {(int)caracter}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Concatenación de cadenas de texto");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena1 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena1}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Ingrese otra cadena de texto: ");
string cadena2 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena2}");
Console.WriteLine("-----------------------------------------------------------");
string cadenaConcatenada = cadena1 + " " + cadena2;
Console.WriteLine("Cadenas concatenadas: " + cadenaConcatenada);
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Comparación de cadenas de texto");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena3 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena3}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Ingrese otra cadena de texto: ");
string cadena4 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena4}");
Console.WriteLine("-----------------------------------------------------------");
if (cadena3 == cadena4)
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas son diferentes");
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Comparación de cadenas de texto (ignorando mayúsculas y minúsculas)");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena5 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena5}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Ingrese otra cadena de texto: ");
string cadena6 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena6}");
Console.WriteLine("-----------------------------------------------------------");
if (cadena5.ToLower() == cadena6.ToLower())
{
    Console.WriteLine("Las cadenas son iguales");
}
else
{
    Console.WriteLine("Las cadenas son diferentes");
}
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Longitud de una cadena de texto");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.WriteLine("Ingrese una cadena de texto: ");
string cadena7 = Console.ReadLine();
Console.WriteLine($"Cadena ingresada: {cadena7}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine($"La longitud de la cadena es: {cadena7.Length}");
Console.WriteLine("-----------------------------------------------------------");
Console.WriteLine("Presione una tecla para continuar...");
Console.ReadKey();
Console.Clear();
Console.ForegroundColor = color;

