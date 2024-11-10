using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsAbstractInterfacesEg
{
    /*Polymorphism
    1.Static--Overloading  Eg. Calculator-has add method with different signature.Its called static because the method gets associated with the object
                            // eg calc.Add(10) at compiletime...so if is fixed
                            // No delay during the time of Execution....Its not flexible...We cannot change decision of which method has to be called during runtime
    2.Dynamic--Overriding  //If we want to postpone binding of a method to its object during runttime then its called dynamic Polymorphism


    Inheritance
    Virtual function
    The inherited class can modify the virtual function according to its requirement
    The call to a virtual function is decided at runtime
    */
    

    namespace VirtualFunction
    {
         class Animal
        {
            public virtual void FoodHabits() //making this method invisible to compiler and associate the method only during time of execution DYNAMIC BINDING
            {
                Console.WriteLine("Animals has different food habits");
            }
            public void Behaviour() //Is bound to the object at the time of compilation STATIC BINDING
            {
                Console.WriteLine("Animals have 5 senses and they are close to Nature");
            }
            public virtual void Method1()
            {
                Console.WriteLine("Method1");
            }
           
        }
        class Carnivorous : Animal
        {
            //Method Overriding-Creates specialized implementation of the members of a base class in the derived class
            public override void FoodHabits() //Overriding --Method which has same name and same signature also as that of Base Class
            {
                Console.WriteLine("The Carnivorous animals eat only meat");
            }
            public new void Behaviour()
            {
                Console.WriteLine(" Carnivorous Animals have sharp teeth and claws to tear and eat other animals");
            }
            public sealed override void Method1()
            {
                base.Method1();
                Console.WriteLine("Hello after Method1");
            }
          
        }

        class Lion : Carnivorous
        {
            public override void FoodHabits()
            {
                base.FoodHabits();
                Console.WriteLine("Lion Food Habit is strange");
            }
            //public override void Method1()//Cannot override the sealed method
            //{

            //}

        }
        class Herbivorous : Animal
        {
            public override void FoodHabits()
            {
                Console.WriteLine("The Herbivourous animals eat only plants");
            }
            public new void Behaviour()
            {
                Console.WriteLine("Herbivorous Animals have flat teeth and can run fast to escape from predators");
            }
            public void Colour()
            {
                Console.WriteLine("Stripes or Dots");
                
            }
        }
        class Implement
        {
            public void callFunction(Animal Cr)
            {
                Cr.FoodHabits();//Virtual
                Cr.Behaviour();//Normal
            }
        }
        class Birds
        {
            public void Behaviour()
            {
                Console.WriteLine("BB");
            }
            public void FoodHabits()
            {
                Console.WriteLine("BFH");
            }
        }

        
        class ClassMain  //Polymorphism is the ability to allow a function to exist in different forms
        {
            public static void Main()
            {
                Implement Imp = new Implement();
                Animal animal = new Animal();
                Carnivorous cn = new Carnivorous();
                Herbivorous hb = new Herbivorous();
                Console.WriteLine("Call function with animal obj");
                Imp.callFunction(animal);
                Console.WriteLine("Call function with Carnivorous obj");
                Imp.callFunction(cn);//Decision is take during runttime--We can pass object of Base class Animal or any of its derived class
                
                //We can call Behaviour method of Child class only with child class object as it is not declared with Virtual keyword
                Console.WriteLine("Call function with Herbivorous obj");
                
                Imp.callFunction(hb);
                Birds bird = new Birds();
                //Imp.callFunction(bird);--Not possible....We can pass only animal class object or its dervived classes
                Console.WriteLine("Calling the Behaviour method with Carnivorous class obj");
                cn.Behaviour();

                Console.ReadLine();

                Animal animal1;

                animal1 = new Animal();
                animal1.FoodHabits();
                animal.Behaviour();

                animal1 = new Carnivorous();
                animal1.FoodHabits();
                animal1.Behaviour();

                animal1= new Herbivorous();
                animal1.FoodHabits();//Virtual method will call the corresponding method of what is beeing passed
                animal1.Behaviour();//Normal method Always call the method of Base class only

                //Carnivorous car = (Carnivorous)new Animal();--Error...Only parent class object can be used for instantiating child class and Viceversa is not possible


                





            }
        }
    }


}
