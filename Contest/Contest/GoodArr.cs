using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class GoodArr
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            int[] sol = new int[cases];
            for (int i = 0; i < cases; i++)
            {
                int len = Convert.ToInt32(Console.ReadLine());
                char[] con = Console.ReadLine().ToCharArray();
                int[] arr = new int[len];
                for (int j = 0; j < len; j++)
                {
                    arr[j] = Convert.ToInt32(con[j]);
                }
                int sum = 0, cnt = 0;
                for (int j = 1; j < len; j++)
                {
                    for (int t = 0; t < len; t++)
                    {
                        for (int k = t; k < j - 1; k++)
                        {
                            if (k >= len)
                                sum = -1;
                            else
                                sum += arr[k];
                        }
                        if (sum == j)
                        {
                            cnt++;
                            sum = 0;
                        }
                    }

                }
                sol[i] = cnt;
            }
            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(sol[i]);
            }
        }
    }
}
