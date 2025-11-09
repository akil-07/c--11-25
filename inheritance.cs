using System;
namespace inheritance
{
    class program
    {
        static void Main()
        {
            car car=new car();
            bike bike = new bike();
            boat boat = new boat();
            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();
            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            car.go();
            Console.WriteLine(bike.speed);
            Console.WriteLine(bike.wheels);
            car.go();
        }
    }
    class vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("The vehicle is moving!!!");
        }
    }
    class car : vehicle
    {
        public int wheels = 4;
    }
    class bike : vehicle
    {
        public int wheels = 2;
    }
    class boat :vehicle

    {
        public int wheels = 0;
    }

}

