// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Expresiones Aritmeticas, Logicas y relacionales");
int number1 = 45, number2 = 3;
bool result = number1 <= number2;
Console.WriteLine("El resultado es: " + result);
Console.WriteLine("¿Son Iguales?");

int number3 = 45;
int number4 = 45;
bool result1 = number3 == number4;
Console.WriteLine("El Resultado es: " + result);
if (number1 > 0)
{
    Console.WriteLine($"El numero {number1} es mayor a 0");
}
else
{
    Console.WriteLine($"El número {number1} no es mayor a 0");
}

//ejemplo de switch
int number = 0;
Console.WriteLine("Ingrese un numero");
string stringData = Console.ReadLine();
int.TryParse(stringData, out number);
switch (number)
{
    case 1:
        Console.WriteLine("El numero ingresado es 1");
        break;
    case 2:
        Console.WriteLine("El numero ingresado es 2");
        break;
    default:
        Console.WriteLine("Es diferente de 1 y 2");
        break;

}
