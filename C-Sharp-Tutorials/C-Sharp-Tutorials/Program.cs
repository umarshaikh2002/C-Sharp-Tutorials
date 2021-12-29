using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorials
{
    public class Program
    {
        static void Main(string[] args)
        {
            IStudent student = new Student();

            SW:

            Console.WriteLine("Choose Option");
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Remove");
            Console.WriteLine("3. Get");
            Console.WriteLine("4. Get All");
            Console.WriteLine("5. Exit");

            int selection = int.Parse(Console.ReadLine());

            switch (selection)
            {
                case 1:
                    Student student1 = new Student();
                    Console.WriteLine("Enter Id");
                    student1.Id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Name");
                    student1.Name = Console.ReadLine();
                    Console.WriteLine("Enter City");
                    student1.City = Console.ReadLine();
                    Console.WriteLine("Enter Class");
                    student1.Class = Console.ReadLine();
                    Console.WriteLine("Enter Percentage");
                    student1.Percentage = float.Parse(Console.ReadLine());
                    student.Add(student1);
                    break;
                case 2:
                    Console.WriteLine("Enter Id");
                    int id = int.Parse(Console.ReadLine());
                    student.Remove(id);
                    break;

                case 3:
                    Console.WriteLine("Enter Id");
                    id = int.Parse(Console.ReadLine());
                    var s = student.GetStudent(id);
                    Console.WriteLine($"id = {s.Id}");
                    Console.WriteLine($"Name = {s.Name}");
                    Console.WriteLine($"City = {s.City}");
                    Console.WriteLine($"Class = {s.Class}");
                    Console.WriteLine($"Percentage = {s.Percentage}");
                    break;
                case 4:
                    var students = student.GetStudents();

                    foreach (var std in students)
                    {
                        Console.WriteLine($"id = {std.Id}");
                        Console.WriteLine($"Name = {std.Name}");
                        Console.WriteLine($"City = {std.City}");
                        Console.WriteLine($"Class = {std.Class}");
                        Console.WriteLine($"Percentage = {std.Percentage}");
                    }
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("Wrong selection");
                    break;
            }

            goto SW;

            Console.ReadKey();
        }
    }
}
