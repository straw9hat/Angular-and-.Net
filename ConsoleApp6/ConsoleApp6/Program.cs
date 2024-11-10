using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{

    public delegate void SimpleDelegate();

    class Delegate
    {
        public static void MyFunction5()
        {
            Console.WriteLine("1st line");
        }
        public static void MyFunction6()
        {
            Console.WriteLine("2nd line");
        }
        static void Main(string[] args)
        {
            SimpleDelegate simpleDelegate = new SimpleDelegate(MyFunction5);
            simpleDelegate();
            simpleDelegate = new SimpleDelegate(MyFunction6);
            simpleDelegate();
            Console.ReadLine();
        }
    }
}
