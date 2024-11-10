using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Calculator
    {
        public delegate void CalDel(int number1, int number2);

        CalDel calDel;

        public void CalculateEg(int choice)
        {
            if(choice == 1)
            {
                calDel = new CalDel(Add);
            }
            if(choice==2)
            {
                calDel = new CalDel(Mul);
            }
            else 
            {

            }
        }


        public int Add(int num1, int num2)
        {
            int res = num1 + num2;
            Console.WriteLine("Simply add " + res);
            return res;
        }
        public int Mul(int num1,int num2)
        {
            int res = num1 * num2;
            Console.WriteLine("Simply Multiply " + res);
            return res;
        }

        public void GetNumbers()
        {
            Console.WriteLine("Please enter 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Calculate(num1, num2);
        }
        public void Calculate(int n1, int n2)
        {

        }
    }
}
