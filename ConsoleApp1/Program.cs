namespace Baitap1;
internal class Program
{
    public static void Main()
    {
        Ex01();
        /*Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
        Ex10(); */

    }
    static void Ex01()
    {
        Console.Write("Insert your num: x= ");
        int x = int.Parse(Console.ReadLine());
        Console.Write("Insert your num: y= ");
        int y = int.Parse(Console.ReadLine());
        int z = x + y;
        Console.Write("The sum is: x+y= " + z);
        Console.ReadKey();

    }
    static void Ex02()
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        (a, b) = (b, a);
        Console.WriteLine($"Your swapped values: a= " + a + "b= " + b);
        Console.ReadKey();
    }

    static void Ex03()
    {
        float c = float.Parse(Console.ReadLine());
        float d = float.Parse(Console.ReadLine());
        float e = c * d;
        Console.WriteLine($"Tich cua hai so c va d: {e}");
        Console.ReadKey();
    }

    static void Ex04()
    {
        Console.Write("Enter feet: ");
        double feet = double.Parse(Console.ReadLine());
        double meter = feet * 0.3048;
        Console.WriteLine($"Meter: {meter}");
    }

    static void Ex05()
    {
        Console.Write("Enter Celsius: ");
        float cel = float.Parse(Console.ReadLine());
        Console.Write("Enter Fahrenheit: ");
        float fah = float.Parse(Console.ReadLine());
        double s1 = cel * 1.8 + 32;
        Console.WriteLine($"Celsius to Fahrenheit: {s1}");
        double s2 = (fah - 32) * 1.8;
        Console.WriteLine($"Fahrenheit to Celsius: {s2}");
    }

    static void Ex06()
    {
        Console.WriteLine("Size of int: " + sizeof(int));
        Console.WriteLine("Size of float: " + sizeof(float));
        Console.WriteLine("Size of double: " + sizeof(double));
        Console.WriteLine("Size of short: " + sizeof(short));
        Console.WriteLine("Size of long: " + sizeof(long));
        Console.WriteLine("Size of decimal: " + sizeof(decimal));
        Console.WriteLine("Size of char: " + sizeof(char));
    }

    static void Ex07()
    {
        Console.Write("Enter any character: ");
        char input = (char)Console.Read();
        int ascii = (int)input;
        Console.WriteLine($"ASCII: {ascii}");
    }

    static void Ex08()
    {
        double pi = Math.PI;
        Console.WriteLine("Enter the radius: ");
        double radius = double.Parse(Console.ReadLine());
        double area = pi * radius * radius;
        Console.WriteLine($"The area of circle is: {area}");
    }

    static void Ex09()
    {
        Console.WriteLine("Enter the side of the square: ");
        double side = double.Parse(Console.ReadLine());
        double area = side * side;
        Console.WriteLine($"The area of square: {area}");
    }

    static void Ex10()
    {
        Console.WriteLine("Enter the number of days: ");
        int num = int.Parse(Console.ReadLine());
        int year = num / 365;
        int week = (num % 365) / 7;
        int day = (num % 365) % 7;
        Console.WriteLine($"Result: {year} year(s) {week} week(s) {day} day(s)");
    }
}