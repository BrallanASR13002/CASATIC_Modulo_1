internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        ConsoleColor color = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Clear();
        Console.WriteLine("Tipos de variables en C# y sus valores máximos y mínimos");
        Console.WriteLine("------------------");
        Console.WriteLine("byte: " + byte.MinValue + " a " + byte.MaxValue);
        Console.WriteLine("Ejemplo de byte: ");
        byte b = 255;
        Console.WriteLine("byte b = " + b);
        Console.WriteLine("char: " + char.MinValue + " a " + char.MaxValue);
        Console.WriteLine("Ejemplo de char: ");
        char c = 'A';
        Console.WriteLine("char c = " + c);
        Console.WriteLine("bool: " + bool.FalseString + " a " + bool.TrueString);
        Console.WriteLine("Ejemplo de bool: ");
        bool bo = true;
        Console.WriteLine("bool bo = " + bo);
        Console.WriteLine("sbyte: " + sbyte.MinValue + " a " + sbyte.MaxValue);
        Console.WriteLine("Ejemplo de sbyte: ");
        sbyte sb = -128;
        Console.WriteLine("sbyte sb = " + sb);
        Console.WriteLine("ushort: " + ushort.MinValue + " a " + ushort.MaxValue);
        Console.WriteLine("Ejemplo de ushort: ");
        ushort us = 65535;
        Console.WriteLine("ushort us = " + us);
        Console.WriteLine("uint: " + uint.MinValue + " a " + uint.MaxValue);
        Console.WriteLine("Ejemplo de uint: ");
        uint ui = 4294967295;
        Console.WriteLine("uint ui = " + ui);
        Console.WriteLine("ulong: " + ulong.MinValue + " a " + ulong.MaxValue);
        Console.WriteLine("Ejemplo de ulong: ");
        ulong ul = 18446744073709551615;
        Console.WriteLine("ulong ul = " + ul);
        Console.WriteLine("short: " + short.MinValue + " a " + short.MaxValue);
        Console.WriteLine("Ejemplo de short: ");
        short sh = -32768;
        Console.WriteLine("short sh = " + sh);
        Console.WriteLine("int: " + int.MinValue + " a " + int.MaxValue);
        Console.WriteLine("Ejemplo de int: ");
        int i = 2147483647;
        Console.WriteLine("int i = " + i);
        Console.WriteLine("long: " + long.MinValue + " a " + long.MaxValue);
        Console.WriteLine("Ejemplo de long: ");
        long l = 9223372036854775807;
        Console.WriteLine("long l = " + l);
        Console.WriteLine("float: " + float.MinValue + " a " + float.MaxValue);
        Console.WriteLine("Ejemplo de float: ");
        float f = 3.40282347E+38F;
        Console.WriteLine("float f = " + f);
        Console.WriteLine("double: " + double.MinValue + " a " + double.MaxValue);
        Console.WriteLine("Ejemplo de double: ");
        double d = 1.7976931348623157E+308;
        Console.WriteLine("double d = " + d);
        Console.WriteLine("decimal: " + decimal.MinValue + " a " + decimal.MaxValue);
        Console.WriteLine("Ejemplo de decimal: ");
        decimal de = 79228162514264337593543950335M;
        Console.WriteLine("decimal de = " + de);
        Console.ForegroundColor = color;
        Console.WriteLine("Presiona cualquier tecla para salir");
        Console.ReadKey();
        Console.Clear();
    }
}