internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cálculo del Área de un círculo:");
        Console.WriteLine("Ingrese el valor del radius: ");

        /* The line `string radius = Console.ReadLine();` is reading input from the user through the console
        and storing it as a string variable named `radius`. The user is expected to input the value of the
        radius of a circle, which will be used in the subsequent calculations to determine the area of the
        circle. */
        string radius = Console.ReadLine();
        int convertednumber = 0;
        /* The line `int.TryParse(radius, out convertednumber);` is attempting to convert the string variable
        `radius` (which is assumed to contain a numerical value entered by the user) into an integer. */
        int.TryParse(radius, out convertednumber);
        /* The line `Console.WriteLine("Valor ingresado: " + radius);` is outputting a message to the console
        that includes the text "Valor ingresado: " followed by the value stored in the `radius` variable. */
        Console.WriteLine("Valor ingresado: " + radius);
        /* The line `double pi = 3.141592 * convertednumber * convertednumber;` is calculating the area of a
        circle based on the formula for the area of a circle, which is πr^2 (pi times the radius squared). */
        double pi = 3.141592 * convertednumber * convertednumber;
        double areaCircle = pi;
        Console.WriteLine("El valor del área del círculo es: ");
        /* The line `Console.WriteLine(areaCircle);` is responsible for outputting the calculated value of the
        area of the circle to the console. This line displays the result of the area calculation, which was
        stored in the variable `areaCircle`, to the user. */
        Console.WriteLine(areaCircle);
        int result = 45 + 3;
        Console.WriteLine(result);
    }
}