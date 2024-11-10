using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace OopsAbstractInterfacesEg
{
    public static class DrawEg
    {
        public static void DrawLine()
        {
            Console.WriteLine("____________________");
        }
        

    }
    class Program
    {
        static void Main()
        {
            //DrawEg d = new DrawEg();
            DrawEg.DrawLine();
            Console.WriteLine("Static class predefined in C# is Console class");
            Console.ReadKey();

        }
    }
}
