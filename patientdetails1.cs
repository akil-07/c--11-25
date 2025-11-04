using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter patient name: ");
        string name = Console.ReadLine();

        Console.Write("Enter room charge: ");
        double roomCharge = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter medicine cost: ");
        double medicineCost = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter doctor fee: ");
        double doctorFee = Convert.ToDouble(Console.ReadLine());

        double totalCost = roomCharge + medicineCost + doctorFee;

        Console.WriteLine("\n--- Patient Bill ---");
        Console.WriteLine("Patient Name: " + name);
        Console.WriteLine("Total Cost: ₹" + totalCost);
    }
}