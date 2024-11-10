using ConsoleApp5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class Employee
    {
        int x;
        public int X { get { return x; } set {x=value; } }

        private int id;
        public string Name;
        internal int salary; //It takes the default previlege for the variable....
                     //In CSharp the default is private for member variables

        public Employee(int id, string Name, int salary)
        {
            this.id = id;
            this.Name = Name;
            this.salary = salary;
        }

        internal void DisplayEmpdetails()
        {
            Console.WriteLine(" id {0} && Name {1} &&  salary{2} ", id, Name, salary);
        }

        ~Employee()
        {
            Console.WriteLine(" Destructor is called");
        }
        public static void Main()
        {
            int i, s;
            string n;
            Employee[] employees = new Employee[4];

            //for (int j = 0; j < employees.Length; j++)
            //{
            //    Console.WriteLine("Enter the ID Name and Salary");
            //    i = Convert.ToInt32(Console.ReadLine());
            //    n = Console.ReadLine();
            //    s = Convert.ToInt32(Console.ReadLine());
            //    employees[j] = new Employee(i, n, s);

            //}
            employees[0] = new Employee(10, "Sunil", 20000);
            employees[1] = new Employee(11, "Vanitha", 30000);
            employees[2] = new Employee(10, "Sai", 20000);
            employees[3] = new Employee(11, "Ram", 30000);

            //for (int k = 0; k < employee.Length; k++)
            //{
            //    employee[k].DisplayEmpdetails();
            //}


            foreach (Employee emp in employees)
            {
                emp.DisplayEmpdetails();
            }

            float[] bonus = new float[5] { 5f, 7.5f, 10f, 12.5f, 15f };

            foreach (float b in bonus)
            {
                Console.WriteLine("Bonus is : " + b);
            }
            Console.Read();
        }

    }
}
    public class EmployeeProgram
{
    static void Main()
    {
        Employee emp = new Employee(101, "Kavin", 40000);

        //emp.id = 102; Error as id is private
        emp.Name = "Kanav";
        emp.salary = 500000; // Error as there is no public access specifier

        emp.DisplayEmpdetails();//We can access internal members between classes within the same namespace
        Console.ReadKey();
    }
}


namespace AccessSpecifierInternalEg
{
    public class DemoEmployeeProgram
    {
        static void Main()
        {
            Employee emp = new Employee(102, "Kavin", 30000);
            emp.salary = 50000;
            emp.DisplayEmpdetails();
        }
    }
}