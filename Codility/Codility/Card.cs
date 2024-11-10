using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codility
{
    class Card
    {
        static void Main()
        {
            char[] cNo = Console.ReadLine().ToCharArray();
            if (cNo.Length != 16)
            {
                Console.WriteLine("Invalid number");
                return;
            }
            int sum = 0;
            int x;
            for(int i=cNo.Length-1;i>=0;i--)
            {
                if (i % 2 != 0)
                {
                    if (2 * (int)cNo[i] -96 > 9)
                    {
                        x = ((int)cNo[i] -48) / 10 + ((int)cNo[i]-48) % 10;
                        sum += x;
                        continue;
                    }
                    sum += 2 * (int)cNo[i]-96;
                }
                else
                    sum += (int)cNo[i]-48;
            }
            if (sum % 10 == 0)
                Console.WriteLine("Valid"+sum);
            else
                Console.WriteLine("Invalid number"+sum);
            Console.ReadLine();
        }
    }
}
