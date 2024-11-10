using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Polycarp
    {
        static void Main(string[] args)
        {
            int cases = Convert.ToInt32(Console.ReadLine());
            List<int> fire = new List<int>();
            List<int> light = new List<int>();
            List<int> res = new List<int>();
            int[] sol = new int[cases];
            for (int i = 0; i < cases; i++)
            {
                string[] tokens = Console.ReadLine().Split(' ');
                int a = int.Parse(tokens[0]);
                int b = Math.Abs(int.Parse(tokens[1]));
                if(a==0)
                {
                    if (fire.Contains(b))
                        fire.Add(b);
                    else
                        fire.Remove(b);
                }
                if (a == 1)
                {
                    if (light.Contains(b))
                        light.Add(b);
                    else
                        light.Remove(b);
                }
                light.Sort();
                light.Reverse();
                fire.Sort();
                fire.Reverse();
                for(int j=0;j<cases;j++)
                {
                    if (j < light.Count)
                        res.Add(light[j]);
                    if (j < fire.Count)
                        res.Add(fire[j]);
                }
                int sum = 0;
                for(int j=0;j<res.Count;j++)
                {
                    if (j % 2 == 0)
                        sum += res[j];
                    else
                        sum += 2*(res[j]);
                }
                sol[i] = sum;
            }
            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(sol[i]);
            }
        }
    }
    }
}
