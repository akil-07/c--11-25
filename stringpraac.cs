using System;
namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sting=");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a number in **-**-** format");
            string num = Console.ReadLine();

            string cap = name.ToUpper();
            Console.WriteLine(cap);
            string low = name.ToLower();
            Console.WriteLine(low);
            string rep = num.Replace("-", "/");
            Console.WriteLine(rep);
            string sub = name.Substring(0,3);
            Console.WriteLine(sub);
        }

    }

}