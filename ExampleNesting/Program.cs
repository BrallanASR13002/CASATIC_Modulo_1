// See https://aka.ms/new-console-template for more information
Console.WriteLine("Estructuras anidadas");
string answerQuest1 = " ", answerQuest2 = " ", answerQuest3 = " ";
Console.WriteLine("¿Tiene usted un horno de microondas? ");
Console.WriteLine("a. Si");
Console.WriteLine("b. No");
Console.WriteLine("Ingrese su Respuesta: ");
answerQuest1 = Console.ReadLine();
if (answerQuest1 == "a")
{
    Console.WriteLine("Si en la anterior pregunta contesto que Si:");
    Console.WriteLine("¿Cuántas horas a la semana lo utiliza?");
    Console.WriteLine("a. 5 horas");
    Console.WriteLine("b. 6 horas");
    Console.WriteLine("c. 8 horas");
    Console.WriteLine("d. mas de 10 horas");
    Console.WriteLine("Ingrese su Respuesta: ");
    answerQuest2 = Console.ReadLine();
    switch (answerQuest2)
    {
        case "a":
            Console.WriteLine("Opción elegida: 5 horas");
            break;
        case "b":
            Console.WriteLine("Opción elegida: 6 horas");
            break;
        case "c":
            Console.WriteLine("Opción elegida: 8 horas");
            break;
        default:
            Console.WriteLine("Opción elegida: mas de 10 horas");
            break;
    }
}
else
{
    Console.WriteLine("Si en la anterior pregunta contesto que No:");
    Console.WriteLine("¿Que otro electrodoméstico utiliza para calentar sus alimentos?");
    Console.WriteLine("a. Horno tostador");
    Console.WriteLine("b. Cocina de gas");
    Console.WriteLine("c. Cocina eléctrica");
    Console.WriteLine("d. Pido delivery");
    Console.WriteLine("Ingrese su Respuesta: ");
    answerQuest3 = Console.ReadLine();
    switch (answerQuest3)
    {
        case "a":
            Console.WriteLine("Opción elegida: Horno tostador");
            break;
        case "b":
            Console.WriteLine("Opción elegida: Cocina de gas");
            break;
        case "c":
            Console.WriteLine("Opción elegida: Cocina eléctrica");
            break;
        default:
            Console.WriteLine("Opción elegida: Pido delivery");
            break;
    }
}
