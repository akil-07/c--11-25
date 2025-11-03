using System;

class Calculator
{
    static void Main()
    {
        Console.WriteLine("Simple Calculator");
        Console.WriteLine("-----------------");

        while (true)
        {
            Console.Write("Enter first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter operator (+, -, *, /): ");
            char op = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = Calculate(num1, num2, op);
            Console.WriteLine($"Result: {result}\n");

            Console.Write("Do you want to continue? (y/n): ");
            char choice = Convert.ToChar(Console.ReadLine());
            if (choice == 'n' || choice == 'N')
                break;
        }

        Console.WriteLine("Thanks for using the calculator!");
    }

    static double Calculate(double a, double b, char op)
    {
        switch (op)
        {
            case '+': return a + b;
            case '-': return a - b;
            case '*': return a * b;
            case '/': return b != 0 ? a / b : double.NaN;
            default:
                Console.WriteLine("Invalid operator!");
                return 0;
        }
    }
}

