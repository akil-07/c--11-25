using System;
using System.Collections.Generic;

class Student
{
    public int RollNo { get; set; }
    public string Name { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int choice;

        do
        {
            Console.WriteLine("\n--- Student Management System ---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View All Students");
            Console.WriteLine("3. Search Student by Roll No");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    AddStudent(students);
                    break;
                case 2:
                    ViewStudents(students);
                    break;
                case 3:
                    SearchStudent(students);
                    break;
                case 4:
                    DeleteStudent(students);
                    break;
                case 5:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice! Try again.");
                    break;
            }

        } while (choice != 5);
    }

    static void AddStudent(List<Student> students)
    {
        Student s = new Student();
        Console.Write("Enter Roll No: ");
        s.RollNo = int.Parse(Console.ReadLine());
        Console.Write("Enter Name: ");
        s.Name = Console.ReadLine();
        Console.Write("Enter Marks: ");
        s.Marks = int.Parse(Console.ReadLine());

        students.Add(s);
        Console.WriteLine("Student added successfully!");
    }

    static void ViewStudents(List<Student> students)
    {
        Console.WriteLine("\n--- Student List ---");
        if (students.Count == 0)
        {
            Console.WriteLine("No students available.");
            return;
        }

        foreach (var s in students)
        {
            Console.WriteLine($"Roll No: {s.RollNo}, Name: {s.Name}, Marks: {s.Marks}");
        }
    }

    static void SearchStudent(List<Student> students)
    {
        Console.Write("Enter Roll No to search: ");
        int roll = int.Parse(Console.ReadLine());

        Student found = students.Find(s => s.RollNo == roll);

        if (found != null)
        {
            Console.WriteLine($"Found -> Roll No: {found.RollNo}, Name: {found.Name}, Marks: {found.Marks}");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }

    static void DeleteStudent(List<Student> students)
    {
        Console.Write("Enter Roll No to delete: ");
        int roll = int.Parse(Console.ReadLine());

        Student found = students.Find(s => s.RollNo == roll);

        if (found != null)
        {
            students.Remove(found);
            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found!");
        }
    }
}
