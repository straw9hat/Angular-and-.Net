using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class MyIndexer
    {
        private string[] name = new string[5];
        private string[] city = new string[5];

        public string this[int index]
        {
            get
            {
                return name[index];
            }
            set
            {
                name[index] = value;
            }
        }
    }


    class MyMain
    {
        public static void Main(string[] args)
        {
            MyIndexer ind = new MyIndexer();

            ind[1] = "Naruto";
            ind[2] = "Luffy";
            ind[3] = "Ichigo";
            ind[4] = "Natsu";
            ind[5] = "Goku";
        }
    }


}
