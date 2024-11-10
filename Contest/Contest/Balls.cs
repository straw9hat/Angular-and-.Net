using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Balls
    {
        static void Main(string[] args)
        {
            int cases;
            cases = Convert.ToInt32(Console.ReadLine());
            string[] sol = new string[cases];
            for(int i=0;i<cases;i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int r = int.Parse(tokens[0]);
                int g = int.Parse(tokens[1]);
                int b = int.Parse(tokens[2]);
                int w = int.Parse(tokens[3]);
                int flag1 = 0, flag2 = 0, flag3 = 0, flag4 = 0;
                if (r % 2 == 0)
                    flag1 = 1;
                if (g % 2 == 0)
                    flag2 = 1;
                if (b % 2 == 0)
                    flag3 = 1;
                if (w % 2 == 0)
                    flag4 = 1;
                if (r > 0 && g > 0 && b > 0 && w > 0)
                {
                    if ((flag1 == 1 && flag2 == 1 && flag3 == 1 && flag4 == 1) || (flag1 == 0 && flag2 == 0 && flag3 == 0 && flag4 == 0) || (flag1 == 0 && flag2 == 1 && flag3 == 0 && flag4 == 0) ||
                    (flag1 == 1 && flag2 == 0 && flag3 == 1 && flag4 == 1) || (flag1 == 0 && flag2 == 0 && flag3 == 1 && flag4 == 0) || (flag1 == 1 && flag2 == 1 && flag3 == 0 && flag4 == 1) ||
                    (flag1 == 1 && flag2 == 0 && flag3 == 0 && flag4 == 0) || (flag1 == 0 && flag2 == 1 && flag3 == 1 && flag4 == 1))
                    {
                        sol[i] = "Yes";
                    }
                }
                else if ((r == 1 && g == 0 && b == 0 && w == 0) || (r == 0 && g == 1 && b == 0 && w == 0) || (r == 0 && g == 0 && b == 1 && w == 0) || (r == 0 && g == 0 && b == 0 && w == 1) || (r == 0 && g == 0 && b == 0 && w == 0))
                {
                    sol[i] = "Yes";
                }
                else
                    sol[i] = "No";
            }
            for (int i = 0;i< cases;i++)
            {
                Console.WriteLine(sol[i]);
            }
        }
    }
}
