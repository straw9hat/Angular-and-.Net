using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootCamp
{
    class Car
    {
        string Engine;
        int wheels;

        public void GetCarDetails()
        {
            Console.WriteLine("Enter the engine Details");
            Engine = Console.ReadLine();
            Console.WriteLine("Enter the no.of wheels");
            wheels = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintCarDetails()
        {
            Console.WriteLine(Engine);
            Console.WriteLine(wheels);
        }
    }

    class SecondProgram
    {
        static void Main(string[] args)
        {
            Car MyCar = new Car();
            MyCar.GetCarDetails();
            Console.WriteLine("Thanks for choosing us!");
            MyCar.PrintCarDetails();
            Console.ReadLine();
        }
    }
}
