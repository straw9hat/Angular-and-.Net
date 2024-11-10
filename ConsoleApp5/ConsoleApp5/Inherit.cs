using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Constructor of base class");
        }
        ~Base()
        {
            Console.WriteLine("Destructor of base classs");
        }
    }
    class Derived: Base
    {
        public Derived()
        {
            Console.WriteLine("Constructor of derived class");
        }
        ~Derived()
        {
            Console.WriteLine("DEstructor of derived class");
        }
    }

    class BaseDerived
    {
        static void Main()
        {
            Derived obj = new Derived();
            Console.ReadKey();
            obj = null;
            GC.Collect();
            Console.ReadKey();
        }
    }
}
