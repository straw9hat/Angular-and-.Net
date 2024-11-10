using System;
using System.Collections.Generic;

namespace Contest
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = Convert.ToInt32(Console.ReadLine());
            List<int> arr = new List<int>();
            string[] tokens = Console.ReadLine().Split(' ');
            for (int i = 0; i < start; i++)
            {
                arr.Add(int.Parse(tokens[i]));
            }
            int cases = Convert.ToInt32(Console.ReadLine());

            string[] sol = new string[cases];
            for (int i = 0; i < cases; i++)
            {
                string[] col = Console.ReadLine().Split(' ');
                char c = Convert.ToChar(col[0]);
                int a = int.Parse(col[1]);
                if (c == '+')
                {
                    arr.Add(a);
                }

                if (c == '-')
                {
                    arr.Remove(a);
                }
                arr.Sort();
                int[] arr1 = new int[arr.Count];
                int k = 0;
                int temp = arr[0];
                int count = 0;
                for (int j = 0; j < arr.Count; j++)
                {

                    if (arr[j] == temp)
                    {
                        count++;
                    }
                    else
                    {
                        arr1[k] = count;
                        k++;
                        count = 1;
                        temp = arr[j];
                    }

                    arr1[k] = count;
                }
                int sq = 0;
                int rec = 0;
                int spe = 0;
                int dob = 0;
                for (int j = 0; j < arr1.Length; j++)
                {


                    if (arr1[j] >= 2 && arr1[j] < 4)
                        rec++;
                    else if (arr1[j] >= 4 && arr1[j] < 6)
                        sq++;
                    else if (arr1[j] >= 6 && arr1[j] < 8)
                        spe++;
                    else if (arr1[j] > 8)
                        dob++;
                }
                if ((sq > 0 && rec > 1) || (spe > 0 && rec > 0) || dob > 0 || sq > 1 || spe > 1)
                    sol[i] = "YES";
                else
                    sol[i] = "NO";


            }
            for (int i = 0; i < cases; i++)
            {
                Console.WriteLine(sol[i]);
            }
        }
    }
}

