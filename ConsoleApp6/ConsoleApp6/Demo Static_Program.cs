using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StaticFunctionExample
{
    public class StaticExample
    {
        public static int s = 3;
        public void count()
        {
            s++;
        }
        public static int display()
        {
            return s;
        }
    }
    class StaticExampleProgram
    {
        public void Demo()
        {
            StaticExample s = new StaticExample();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("The value of variable 		is {0}", StaticExample.display());
            Console.ReadKey();
        }
        public static void abc()
        {
            StaticExample s = new StaticExample();
            s.count();
            s.count();
            s.count();
            Console.WriteLine("The value of variable 		is {0}", StaticExample.display());
            Console.ReadKey();
        }
        static int Main(string[] args)
        {
            new StaticExampleProgram().Demo();
            StaticExample.display();
            //Demo();//Error--Cannot call a function without an instance of the class
            abc();//We can call a static Function directly within another static function
            return 0;
        }
    }

}
