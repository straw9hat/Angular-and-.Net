using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Class1
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int m = int.Parse(tokens[0]);
            int n = int.Parse(tokens[1]);
            if (m > 3 && n > 3)
                Console.WriteLine(-1);
            else
            {
                int[] sol = new int[3];
                int count = 0;
                if(m==3)
                {
                    char[,] arr = new char[m, n];
                    for(int i=0;i<m;i++)
                    {
                        char[] lin = Console.ReadLine().ToCharArray();
                        for (int j=0;j<n;j++)
                        {
                            arr[i,j] = lin[j];
                            
                        }
                    }
                    for(int i=0;i<n;i++)
                    {
                        if(i%3 ==0)
                        {

                        }
                    }
                }
            }
        }
    }
}
