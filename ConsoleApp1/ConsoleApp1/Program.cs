using System;

public class Test
{
	public static void Main()
	{
		int cases;
		cases = Convert.ToInt32(Console.ReadLine());
		string[] sol = new string[cases];
		for (int i = 0; i < cases; i++)
		{
			int len;
			len = Convert.ToInt32(Console.ReadLine());
			char[] str = new char[len];
			str = Console.ReadLine().ToCharArray();
			Array.Sort(str);
			int flag = 0;
			for (int j = 0; j < len; j = j + 2)
			{
				if (str[i] != str[i + 1])
				{
					flag = 1;
				}
			}
			if (flag == 0)
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