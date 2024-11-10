using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public delegate int CalDel(int number1, int number2);//used to point to a method which has int as return and 2 int as input parameters and Always the access specifier for delegates hsould be public only

    class CalculateEg
    {
        //Creating our own delegate type


        CalDel calDel;//creating the reference for our deletegate type

        public CalculateEg(int choice)
        {
            if (choice == 1)
                calDel = new CalDel(Mul);//instantiating the reff
            else
                calDel = new CalDel(Add);

        }
        public int Add(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("Simply add 2 numbers " + res);
            return res;
        }
        public int Mul(int n1, int n2)
        {
            int res = n1 * n2;
            Console.WriteLine("Simply Mul 2 numbers " + res);
            return res;
        }

        public void GetNumbers()
        {
            Console.WriteLine("Please enter the number 1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the number 2");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Calculate(num1, num2);//passing the method as paramter
        }


        public void Calculate(int num1, int num2)
        {
            //passing parameters to method using delegate
            int answer = calDel(num1, num2); //using the reference to invoke the delegate
            Console.WriteLine("The result is :{0}", answer);
        }


    }

    class Demo
    {
        static void Main()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("Enter your choice\t 1.Multiple 2.Add 0.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                if (choice != 0)
                    new CalculateEg(choice).GetNumbers();
            } while (choice != 0);

            CalculateEg c = new CalculateEg(1);

            CalDel obj = new CalDel(c.Add);
            obj(3, 5);

            obj = new CalDel(c.Mul);
            obj(3, 5);

            Console.ReadKey();
        }
    }
}
