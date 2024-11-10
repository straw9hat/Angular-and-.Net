using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases;
            cases = Convert.ToInt32(Console.ReadLine());
            string[] sol = new string[cases];
            for (int i = 0; i < cases; i++)
            {
                int len = Convert.ToInt32(Console.ReadLine());
                if(len==1)
                {
                    sol[i] = "YES";
                    continue;
                }

                int[] arr = Console.ReadLine().Split(new Char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(item => int.Parse(item)).ToArray();

                Array.Sort<int>(arr);
                int flag = 0;
                int flag2 = 0;
                for(int j =0;j<len-1;j++)
                {
                    if (Math.Abs(arr[j] - arr[j + 1]) > 1)
                        flag = 1;
                }
                for(int j=len-1;j>1;j--)
                {
                    if (Math.Abs(arr[j] - arr[j - 1]) > 1)
                        flag2 = 1;
                }
                if(flag==1 && flag2==1)
                {
                    sol[i] = "NO";
                }
                else
                {
                    sol[i] = "YES";
                }
            }
            for (int k = 0; k < cases; k++)
            {

                Console.WriteLine(sol[k]);
            }
        }
    }
}
