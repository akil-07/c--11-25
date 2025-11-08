using System;
namespace exceptions
{
    class program
    {
        static void Main()
        {
            double x;
            double y;
            double result;
            try
            {
                Console.WriteLine("Enter number 1:");
                x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number 2:");
                y = Convert.ToInt32(Console.ReadLine());
                result = x / y;
                Console.WriteLine("result = " + result);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Enter only numbers please");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You can't divide a number by Zero");
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong!!!");
            }
            
        }
    }
    
}
