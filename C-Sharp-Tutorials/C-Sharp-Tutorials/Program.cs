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
            //Employee employee = new Employee(10, 20);
            //employee.Print();
            //employee.Print(100);

            ////Employee employee2 = new Employee();

            //Console.WriteLine(Employee.num3);
            //Console.WriteLine(Employee.num4);

            //Customer customer = new Customer();

            CopyConstructorDemo copyConstructor = new CopyConstructorDemo(1, "Umar");
            Console.WriteLine($"Id = {copyConstructor.Id} & Name = {copyConstructor.Name}");

            //Copy contructor call
            CopyConstructorDemo copyConstructor1 = new CopyConstructorDemo(copyConstructor);
            Console.WriteLine($"Id = {copyConstructor1.Id} & Name = {copyConstructor1.Name}");


            Console.ReadKey();
        }

    }

    public class Employee
    {
        int num1, num2;
        public static int num3, num4;
        static Employee()
        {
            Console.WriteLine("Default constructor");
        }

        public Employee(int a, int b)
        {
            num1 = a;
            num2 = b;
        }

        public void Print()
        {
            Console.WriteLine($"num1 = {num1} & num2 = {num2}");
        }

        public void Print(int a)
        {
            Console.WriteLine(a);
        }

        public void Print(int a, int b)
        {
            Console.WriteLine(a);
        }
    }
}
