using System;
using System.Collections.Generic;
using System.Text;

namespace Contest
{
    class Rearrange
    {
		public static void Main()
		{
			int cases = Convert.ToInt32(Console.ReadLine());
			string[] sol = new string[cases];
			for (int n = 0; n < cases; n++)
			{
				char[] arr1;
				arr1 = Console.ReadLine().ToCharArray();
				char[] arr2 = Console.ReadLine().ToCharArray();
				List<char> res = new List<char>();
				for (int i = 0; i < arr1.Length; i++)
				{
					res.Add(arr1[i]);
				}
				res.Sort();
				for (int i = 0; i < arr2.Length; i++)
				{
					res.Remove(arr2[i]);

				}
				int flag = 0;
				for (int i = 0; i < res.Count; i++)
				{
					if (res[i] > arr2[0] && flag == 0)
					{
						for (int j = 0; j < arr2.Length; j++)
						{
							sol[n] = sol[n] + Convert.ToString(arr2[j]);
						}
						flag = 1;

					}
					sol[n] = sol[n] + Convert.ToString(res[i]);
				}
			}
			for (int n = 0; n < cases - 1; n++)
			{
				Console.WriteLine(sol[n]);
			}
			Console.Write(sol[cases - 1]);
		}
	}
}
