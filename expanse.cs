using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
class expanse
{ 
    public DateTime Date {  get; set; }
    public string Catagory {  get; set; }
    public string Description {  get; set; }
    public double Amount {  get; set; }
    public expanse(DateTime date,string catagory, string description,double amount)
    {
        Date = date;
        Catagory = catagory;
        Description=description; 
        Amount=amount;
    }
    public void Display()
    {
        Console.WriteLine($"{Date.ToShortDateString(),-12} | {Catagory,-10} | {Description,-20}");
    }
    public string ToCsv()
    {
        return $"{Date},{Catagory},{Description},{Amount}";
    }
    public static expanse FromCsv(string line)
    {
        string[] parts = line.Split(',');
        return new expanse(
            DateTime.Parse(parts[0]),
             parts[1],
             parts[2],
             double.Parse(parts[3])
        );
    }

}
class program
{
    static string filepath = "expanses.csv";
    static void Main()
    {
        List<expanse> expanses = loadexpanses();
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n===== EXPANSE TRACKER =====");
            Console.WriteLine("1.Add Expnase");
            Console.WriteLine("2.View Expanse");
            Console.WriteLine("3,View expanse by catagories");
            Console.WriteLine("4.View Expanses");
            Console.WriteLine("5.Exit");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    addexpanse(expanses);
                        break;
                case "2":
                    viewexpanse(expanses); 
                    break;
                case "3":
                    Viewbycategory(expanses);
                    break;
                case "4":
                    viewsummary(expanses);
                    break;
                case "5":
                    saveexpanses(expanses);
                    running = false;
                    Console.WriteLine("Data saved...EXITING....");
                    break;
                default:
                    Console.WriteLine("Tnvalid choice...TRY AGAIN....");
                    break;
            }
        }
    }
    static void addexpanse(List<expanse> expanses)
    {
        Console.WriteLine("\n--- ADD EXPANSES ---");
        Console.WriteLine("Enter date (yyyy-mm-dd): ");
        DateTime date;
        while(!DateTime.TryParse(Console.ReadLine(),out date))
        {
            Console.WriteLine("Invalid date.Please enter again(yyyy-mm-dd): ");
        }
        Console.WriteLine("Enter category(Food, Travel, Bills, etc...): ");
        string category = Console.ReadLine();
        Console.WriteLine("Enter description: ");
        string description = Console.ReadLine();
        Console.WriteLine("Enter amount: ");
        double amount;
        while(!double.TryParse(Console.ReadLine(), out amount) || amount<0)
        {
            Console.WriteLine("Invalid amount. Enter positive number: ");
        }
        expanse expanse = new(date, category, description,amount);
        expanses.Add(expanse);
        Console.WriteLine("Expanse added succesfully!!!");
    }
    static void viewexpanse(List<expanse> expanses)
    {
        if(expanses.Count==0)
        {
            Console.WriteLine("\nNo expanses found.");
            return;
        }
        Console.WriteLine("\n--- ALL EXPANSES ---");
        Console.WriteLine("Date         | Catogery  | Description          |Amount");
        Console.WriteLine("-------------------------------------------------------------");
        double total = 0;
        foreach(expanse exp in expanses)
        {
            total += exp.Amount;
        }
        Console.WriteLine($"Total spent: {total:F2}");
    }
    static void Viewbycategory(List<expanse>expanses)
    {
        Console.WriteLine("\nEnter category to filter: ");
        string filter = Console.ReadLine().ToLower();
        var filtered = expanses.FindAll(e=>e.Catagory.ToLower()==filter);
        if (filtered.Count == 0)
        {
            {
                Console.WriteLine("No expanses found in this category");
                return;
            }
        }
        Console.WriteLine($"\n--- EXPANSES IN '{filter.ToUpper()}'---");
        Console.WriteLine("Date          | Category    | Description          | Amount");
        Console.WriteLine("---------------------------------------------------------------");
        foreach(expanse exp in filtered)
        {
            exp.Display();
        }
        double total = 0;
        foreach (expanse exp in filtered)
        {
            total += exp.Amount;
        }
        Console.WriteLine("--------------------------------------------------------------");
        Console.WriteLine($"Total for {filter}: {total:F2}");
    }
    static void saveexpanses(List<expanse> expanses)
    {
        using (StreamWriter writer = new StreamWriter(filepath))
        {
            foreach(expanse exp in expanses)
            {
                writer.WriteLine(exp.ToCsv());
            }
        }
    }
    static void viewsummary(List<expanse> expanses)
    {
        if(expanses.Count==0)
        {
            Console.WriteLine("\nNo expanese found");
            return;
        }
        Console.WriteLine("\n--- EXPANSE SUMMARY ---");
        double total = 0;
        Dictionary<string, double> categoryTotals = new Dictionary<string, double>();
        foreach (expanse exp in expanses)
        {
            total+=exp.Amount;
            if(categoryTotals.ContainsKey(exp.Catagory))
            {
                categoryTotals[exp.Catagory] += exp.Amount;
            }
            else
            {
                categoryTotals[exp.Catagory] = exp.Amount;
            }
            Console.WriteLine($"Total Spent: {total:F2}");
            Console.WriteLine("\nCatogery wise Breakdown: ");
            foreach(var kvp in categoryTotals)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value:F2}");
            }
        }
    }
    static List<expanse>loadexpanses()
    {
        List<expanse>expanses = new List<expanse>();
        if(File.Exists(filepath))
        {
            string[] lines= File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                if(!string.IsNullOrEmpty(line))
                {
                    expanses.Add(expanse.FromCsv(line));
                }
            }
        }
        return expanses; ;
    }
 
}


