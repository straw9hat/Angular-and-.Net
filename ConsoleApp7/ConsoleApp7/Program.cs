using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public delegate void SimpleDelegate();  //Declare a delegate....it can refer to the methods which have the same signature

    class MyDemo
    {

        public void MyFuncDay5()
        {
            Console.WriteLine("We have to learn DATABASE Connectivity...");
        }
        public void MyFuncDay6()
        {
            Console.WriteLine("We should learn Three Tier Architecture...");
        }
        public void MyFuncDay7()
        {
            Console.WriteLine("Hello");
        }
        public static void Main()
        {
            MyDemo md = new MyDemo();
            SimpleDelegate simpleDelegate = new SimpleDelegate(md.MyFuncDay5);//instatiate a Delegate...we need to assign the address of the required method to the delegate Object


            simpleDelegate();//Use or Calling the delegate

            simpleDelegate = new SimpleDelegate(md.MyFuncDay6);  //Here the Delegate allows you to dynamically change the reference to the methods in a class

            simpleDelegate();//Indirect way of calling a method dynamically

            simpleDelegate = new SimpleDelegate(md.MyFuncDay7);
            simpleDelegate();

            Console.ReadKey();
        }
    }
}