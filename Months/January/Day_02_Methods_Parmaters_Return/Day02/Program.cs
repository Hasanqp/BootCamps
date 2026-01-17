using System;

// Day 2: Methods, Parameters, Return
class Day02
{
    static void Main()
    {
        // Basic return method
        int result = Add(5, 8);
        Console.WriteLine("Add Result: " + result);

        // Void method with parameter
        Greet("Hasan");

        // Bool return method
        Console.WriteLine("Is 4 Even? " + IsEven(4));

        // Method with double parameters
        Console.WriteLine("Rectangle Area: " + RectangleArea(5.5, 3));

        // Method returning max value
        Console.WriteLine("Greater Number: " + GreaterNumber(4, 9, 2));

        // Conversion method
        Console.WriteLine("Temp Convert: " + CelsiusToFahrenheit(25));

        // Validation method
        Console.WriteLine("Age Valid? " + ValidateAge(22));

        // String processing method
        Console.WriteLine("Vowels Count: " + CountVowels("Hasan"));

        // ref parameter example
        int num = 5;
        Increase(ref num);
        Console.WriteLine("Increase ref: " + num);

        // out parameter example
        GetValues(out int x, out int y);
        Console.WriteLine("Out values: " + x + " " + y);

        // Nested method call
        Console.WriteLine("Triple Square: " + TripleSquare(4));

        // ref exercise
        int n = 6;
        DoubleValue(ref n);
        Console.WriteLine("Double ref: " + n);

        // out exercise
        MinMax(4, 9, out int min, out int max);
        Console.WriteLine("Min: " + min + " Max: " + max);

        // Multiple results using out
        Calculate(5, 3, out int s, out int d, out int m);
        Console.WriteLine($"Sum={s}, Diff={d}, Mul={m}");

    }

    // Return sum
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Print greeting
    static void Greet(string name)
    {
        Console.WriteLine("Welcome " + name);
    }

    // Check even number
    static bool IsEven(int num)
    {
        return num % 2 == 0;
    }

    // Rectangle area
    static double RectangleArea(double width, double height)
    {
        return width * height;
    }

    // Get greatest of 3 numbers
    static int GreaterNumber(int a, int b, int c)
    {
        return Math.Max(a, Math.Max(b, c));
    }

    // Celsius to Fahrenheit
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    // Age validation
    static bool ValidateAge(int age)
    {
        return age >= 18 && age <= 60;
    }

    // Count vowels in string
    static int CountVowels(string name)
    {
        int count = 0;
        foreach (char c in name.ToLower())
        {
            if ("aeiou".Contains(c))
                count++;
        }
        return count;
    }

    // ref increase
    static void Increase(ref int x)
    {
        x += 10;
    }

    // out values
    static void GetValues(out int a, out int b)
    {
        a = 10;
        b = 20;
    }
    // Nested Method
    static int Square(int x)
    {
        return x * x;
    }
    static int TripleSquare(int x)
    {
        return Square(x) * 3;
    }

    // ref exercise
    static void DoubleValue(ref int x)
    {
        x *= 2;
    }

    // out min/max
    static void MinMax(int a, int b, out int min, out int max)
    {
        min = Math.Min(a, b);
        max = Math.Max(a, b);
    }

    // out calculator
    static void Calculate(int a, int b, out int sum, out int diff, out int mul)
    {
        sum = a + b;
        diff = a - b;
        mul = a * b;
    }
}