using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Office.Interop.Word;

namespace BootCamp
{
    class Colours
    {
        string c1, c2;
        public void DisplayDetails()
        {
            c1 = Console.ReadLine();
            c2 = Console.ReadLine();
        }

        public void AddColour()
        {
            if((c1=="RED" && c2=="GREEN") || (c1=="GREEN" && c2=="RED"))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("YELLOW");
            }
            else if ((c1 == "BLUE" && c2 == "GREEN") || (c1 == "GREEN" && c2 == "BLUE"))
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("CYAN");
            }
            else if ((c1 == "BLUE" && c2 == "RED") || (c1 == "RED" && c2 == "BLUE"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("MAGENTA");
            }
        }

        static void Main(string[] args)
        {
            Colours cc = new Colours();
            cc.DisplayDetails();
            cc.AddColour();
            Console.ReadLine();
            string s = "yes";
            bool k = s.Application.CheckSpelling();
        }
    }
}
