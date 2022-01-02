using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Tutorials
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { 
                Id = 1,
                Name = "Umar",
            });

            employees.Add(new Employee()
            {
                Id = 3,
                Name = "Hamid",
            });

            employees.Add(new Employee()
            {
                Id = 1,
                Name = "Wasim",
            });

            foreach (Employee e in employees.OrderBy(x => x.Name))
            {
                Console.WriteLine($"Id = {e.Id} Name = {e.Name}");
            }

            Console.WriteLine("-----------------------------------------------------------");

            ArrayList arrayList = new ArrayList();

            arrayList.Add(1);
            arrayList.Add("Umar");

            foreach (var e in arrayList)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("-----------------------------------------------------------");

            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);

            foreach (var e in s)
            {
                Console.WriteLine(e);
            }

            Queue<int> s1 = new Queue<int>();
            s1.Enqueue(1);
            s1.Enqueue(2);
            s1.Enqueue(3);

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var e in s1)
            {
                Console.WriteLine(e);
            }

            Queue s2 = new Queue();
            s2.Enqueue(1);
            s2.Enqueue("Umar");
            s2.Enqueue(3);

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var e in s2)
            {
                Console.WriteLine(e);
            }

            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();

            keyValuePairs.Add(1, "Umar");
            keyValuePairs.Add(3, "Hamid");
            keyValuePairs.Add(2, "Wasim");

            Console.WriteLine("-----------------------------------------------------------");

            foreach(var e in keyValuePairs)
            {
                Console.WriteLine($"key = {e.Key}, Value = {e.Value}");
            }

            SortedDictionary<int, string> keyValuePairs1 = new SortedDictionary<int, string>();

            keyValuePairs1.Add(1, "Umar");
            keyValuePairs1.Add(3, "Hamid");
            keyValuePairs1.Add(2, "Wasim");

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var e in keyValuePairs1)
            {
                Console.WriteLine($"key = {e.Key}, Value = {e.Value}");
            }

            HashSet<int> vs = new HashSet<int>();
            vs.Add(1);
            vs.Add(2);
            vs.Add(2);

            Console.WriteLine("-----------------------------------------------------------");

            foreach (var e in vs)
            {
                Console.WriteLine(e);
            }

            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}