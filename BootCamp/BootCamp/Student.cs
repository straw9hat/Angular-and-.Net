using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    class Student
    {
        static void Main(string[] args)
        {
            string SName;
            int SAge;

            Console.WriteLine("Enter your name");
            SName = Console.ReadLine();
            Console.WriteLine("Enter your age");
            SAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SName + "'s age is " + SAge);
            Console.WriteLine("The name {0}", SName);
            Console.ReadLine();
        }
    }
}
