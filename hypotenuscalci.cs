using System;
namespace practce
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter The Side A:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Side B:");
            double b= Convert.ToDouble(Console.ReadLine());
            double c = Math.Sqrt((a * a) + (b * b));
            Console.WriteLine("the length of c is:"+c);
            double area = 0.5 * a * b;
            double peri = a + b + c;
            Console.WriteLine($"The area is {area}");
            Console.WriteLine($"The perimeter is {peri}");
            Console.ReadKey();
        }
    }
}
    