using System;
namespace constructors
{
    class program
    {
        static void Main(string[] args)
        {
           car car1 = new car("Mustang");
            car car2 = new car("Lambo");
            Console.WriteLine(car.numberofcars);
        }
    }
    class car
    {
        String model;
        public static int numberofcars;
        public car(String model)
        {
            this.model = model;
            numberofcars++;
        }
    }
}    