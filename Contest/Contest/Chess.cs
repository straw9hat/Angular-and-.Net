using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Chess
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split(' ');
            int m = int.Parse(tokens[0]);
            int n = int.Parse(tokens[1]);
            int xS = int.Parse(tokens[2]);
            int yS = int.Parse(tokens[3]);
            int x = xS;
            int y = yS;
            int flag = 0;
            for(int i=0;i<9;i++)
            {
                Console.WriteLine(x + " " + y);
                if(y==yS)
                {
                    if(x==n)
                    {
                        x = xS - 1;
                        flag = 1;
                        continue;
                    }
                    x++;
                    if (flag == 0)
                        flag = 1;
                    if (flag == 1)
                        flag = 0;
                    continue;
                }
                if(flag==0)
                {
                    y--;
                    if (y == 1)
                        flag = 1;
                }
                else
                {
                    
                    y++;
                    
                }

            }
        }
    }
}
