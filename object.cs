using System;
namespace obj
{
    class program
    {
        static void Main(string[] args)
        {
            human human1= new human();
            human human2 = new human();
            human1.name = "Akil";
            human1.age = 18;
        }
    }
    class human()
    {
        public int age;
        public string name;
        public void eat()
        {
            Console.WriteLine($"{name} is eating");
        }
        
        public void sleeping()
        {
            Console.WriteLine(name + "is sleeping");
        }
    
    }
}