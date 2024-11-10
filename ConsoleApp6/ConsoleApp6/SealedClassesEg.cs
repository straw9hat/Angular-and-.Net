using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAbstractInterfacesEg
{
    public class Animals
    {

    }
    sealed class Birds:Animals
    {
        private int x;
        public void Method1()
        {

        }
    }
    
    class FlyingBirds:Animals
    {
        private int y;
    }

    //class Duck:Birds-- We cannot extend from a sealed class
    class Duck : FlyingBirds
    {

    }
}
