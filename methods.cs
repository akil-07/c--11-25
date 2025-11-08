using System;
namespace function
{
    class program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number = ");
            int x=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a 2nd number = ");
            int y=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(sum(x,y));
            Console.WriteLine(diff(x,y));
            Console.WriteLine(mul(x,y));
            Console.WriteLine(div(x,y));
        }
        static int sum(int x,int y)
        { return x + y; }
        static int diff(int x,int y)
        { return x - y; }
        static int mul(int x,int y)
        { return x * y; }
        static int div(int x,int y)
        { return x / y; }
    }
}