using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Ones
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            int[] sol = new int[cases];
            for(int i=0;i<cases;i++)
            {
                char[] arr = Console.ReadLine().ToCharArray();
                int cnt = 0;
                List<int> one = new List<int>();
                for(int j=0;j<arr.Length;j++)
                {
                    if(arr[j] == '1')
                    {
                        cnt++;
                    }
                    else
                    {
                        if(cnt!=0)
                        {
                            one.Add(cnt);
                            cnt = 0;
                        }
                    }
                }
                one.Sort();
                sol[i] = 0;
                for(int j=0;j<one.Count;j=j+2)
                {
                    sol[i] += one[j];
                }
            }
            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(sol[i]);
            }
        }
    }
}
