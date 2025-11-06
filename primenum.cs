using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nPrime numbers between {start} and {end} are:");

        for (int i = start; i <= end; i++)
        {
            if (isPrime(i))
                Console.Write(i + " ");
        }
    }

    static bool isPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the starting number: ");
        int start = int.Parse(Console.ReadLine());

        Console.Write("Enter the ending number: ");
        int end = int.Parse(Console.ReadLine());

        Console.WriteLine($"\nPrime numbers between {start} and {end} are:");

        for (int i = start; i <= end; i++)
        {
            if (isPrime(i))
                Console.Write(i + " ");
        }
    }

    static bool isPrime(int num)
    {
        if (num <= 1)
            return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }
}

