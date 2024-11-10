using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Triangle
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            int[] flag = new int[cases];
            for(int i=0;i<cases;i++)
            {
                int num = Convert.ToInt32(Console.ReadLine());
                int[] arr = new int[num];
                string[] tokens = Console.ReadLine().Split(' ');
                int a = int.Parse(tokens[0]);
                int b = int.Parse(tokens[1]);
                int c = int.Parse(tokens[num - 1]);
                if (a + b <= c)
                    flag[i] = 0;
                else
                    flag[i] = num;
            }
            for(int i=0;i<cases;i++)
            {
                if (flag[i] == 0)
                    Console.WriteLine(-1);
                else
                    Console.WriteLine("1 2 " + flag[i]);
            }
        }
    }
}
