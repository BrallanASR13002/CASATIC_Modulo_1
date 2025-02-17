// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World! estructura while");
int countValue = 0;
while (countValue < 5)
{
    Console.WriteLine("El valor del contador es: " + countValue);
    countValue++;
}
Console.WriteLine("\nEstrucrtura do-while");
int countValueDoWhile=0;
do
{
    
    Console.WriteLine("El valor del contador es: " + countValueDoWhile);
    countValueDoWhile++;

} while (countValueDoWhile < 5);
Console.WriteLine("\nEstrucrtura for");
for (int i = 0; i < 5; i++)
{
    Console.WriteLine("El valor del contador es: "+i);
}
int[] numeros = { 1, 2, 3 }; 

for (int i = 0; i <= numeros.Length; i++)  

{ 

    Console.WriteLine(i); 

} 