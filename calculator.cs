using System;
namespace program
{
    class calculator
    {
        static void Main()
        {
            Console.Write("Enter the first number = ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number = ");
            int y = Convert.ToInt32(Console.ReadLine());
            int add = x + y;
            int sub = x - y;
            int mul = x * y;
            int div = x / y;
            Console.WriteLine("The addition is " + add);
            Console.WriteLine("The subraction is " + sub);
            Console.WriteLine("The multiplication is " + mul);
            Console.WriteLine("the division is " + div);
            Console.ReadKey();
        }
    }
}
