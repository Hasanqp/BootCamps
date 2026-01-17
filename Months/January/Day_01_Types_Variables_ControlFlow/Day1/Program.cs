using System;

// Day 1: Types, Variables, Control Flow  
class Day01
{
    static void Main()
    {
        // int examples

        Console.WriteLine("Enter first number:");
        int A = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter second number:");
        int B = Convert.ToInt32(Console.ReadLine());

        int sum = A + B;
        int sub = A - B;
        int mul = A * B;

        if (B != 0)
            Console.WriteLine("Division: " + (A / B));
        else
            Console.WriteLine("Cannot divide by zero");

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Subtraction: " + sub);
        Console.WriteLine("Multiplication: " + mul);

        int half = 1 / 2;
        Console.WriteLine("1 / 2 using int = " + half);

        // double example

        Console.WriteLine("\nEnter product price:");
        double price = Convert.ToDouble(Console.ReadLine());


        double taxRate = 0.15;
        double total = price + (price * taxRate);

        Console.WriteLine("Total after tax: " + total.ToString("0.00"));

        // bool example

        bool isAdult = A >= 18;
        Console.WriteLine("Is Adult? " + isAdult);

        // char example

        char grade = 'A';
        Console.WriteLine("Grade: " + grade);

        // if / else

        if (A > B)
            Console.WriteLine("A is bigger");
        else if (A < B)
            Console.WriteLine("B is bigger");
        else
            Console.WriteLine("Both are equal");

        // for loop

        Console.WriteLine("\nFor loop from 1 to 5:");
        for (int i = 1; i <= 5; i++)
            Console.WriteLine(i);



        // while loop
        Console.WriteLine("\nWhile loop example:");

        int counter = 1;
        while (counter <= 3)
        {
            Console.WriteLine("Loop " + counter);
            counter++;
        }

        Console.WriteLine("Enter a number from 1 to 3:");
        int choice = Convert.ToInt32(Console.ReadLine());

        // switch

        switch (choice)
        {
            case 1: Console.WriteLine("You chose One"); break;
            case 2: Console.WriteLine("You chose Two"); break;
            case 3: Console.WriteLine("You chose Three"); break;
            default: Console.WriteLine("Invalid choice"); break;
        }

    }
}