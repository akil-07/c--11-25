using System;
using System.ComponentModel;
namespace list
{
    class program
    { 
        static void Main()
        {
            List<string> fruits = new List<string>() { "Apple", "Banana", "Mamgo" };
            Console.WriteLine("Fruits list:");
            foreach(string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
        }
    }

}
