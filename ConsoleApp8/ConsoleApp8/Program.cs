using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Parent child = new Child();
            child.method1();
            Program p = new Program();
            p.fSeries(10);
            Console.ReadKey();
        }

        void fSeries(int length)
        {
            int prev = 0;
            int fSum = 1;
            int x;

            Console.WriteLine(0);
            if (length == 1)
            {

            }
            Console.WriteLine(1);
            
            if (length == 2)
            {
                return;
            }
            for(int i=0;i<length-2;i++)
            {
                x = prev + fSum;
                Console.WriteLine(x);
                prev = fSum;
                fSum = x;
                
                
            }
            
        }
    }
    class Parent
    {
        public void method1()
        {
            Console.WriteLine("This is the parent");
        }
    }

    class Child : Parent
    {
        public new void method1()
        {
            Console.WriteLine("This is child");
        }
    }
}
