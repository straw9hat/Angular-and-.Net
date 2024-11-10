using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threaing.Tasks;

namespace ConsoleApp4
{
    class Student
    {
        int RollNo;
        string Name;
        string Class;
        string Sem;
        string Branch;

        int[] Marks = new int[5];

        //Method Declaration

        //Method Overloading

        //1. Method with return type with parameters
        //2. Method without return type with parameters
        //3. Method with return type without parameters
        //4. Method without return type without parameters

        //Methods should be Unique within a Class
        //We can have any number of Methods with same name but they should be defined with different signature
        //Method signature is determined with the Datatype passed,no of arguments passed and the order in which arguments are passed


        //special type of method with the same name as that of Class is called a constructor..
        //Default Constructor is the method with Class name and does not take arguments
        //It will called automically when the class is instatiated
        //The constructor should not have return values
        public Student()
        {
            Console.WriteLine("Default Constructor is called");
            RollNo = 101;
            Name = "Kavin Kumar";
            Class = @"Four\12"; //Use @ To take the absolute value and dont consider the key words or special meaning
            Sem = "One";
            Branch = "CSC";

        }

        //Overloaded Constructors
        public Student(int rollno)
        {
            Console.WriteLine("Overloaded constructor1 is called");
            RollNo = rollno;
        }

        //Overloaded constructor2
        public Student(int rollno, string name)
        {
            Console.WriteLine("Overloaded constructor2 is called");
            RollNo = rollno;
            Name = name;
        }

        public void AcceptStudent()
        {

            Console.WriteLine(@"Accept Student called with no arguments four\12");
        }
        public void AcceptStudent(int rollNo, string name = null, string myclass = null, string sem = null, string branch = null)
        {
            RollNo = rollNo;
            Name = name;
            Class = myclass;
            Sem = sem;
            Branch = branch;
        }

        public void AcceptStudent(int roll)
        {

            Console.WriteLine("Only int");
            Console.WriteLine("Your roll no is {0}", roll);
        }

        public int AcceptStudent(int roll, float marks)//Default value will be assigned only if the user is nor passing any value
        {
            Console.WriteLine("int and float");
            Console.WriteLine("Hello your marks is :{0}", marks);
            return roll;
        }

        public int AcceptStudent(float marks, int roll)//Default value will be assigned only if the user is nor passing any value
        {
            Console.WriteLine("Float and int");
            Console.WriteLine("Hello your marks is :{0}", marks);
            return roll;
        }


        //int[] marks = new int[5] { 35, 50, 40, 60, 55 };
        public void DisplayResult(int[] Marks)
        {
            for (int i = 0; i < 5; i++)
            {
                if (Marks[i] < 35 || Marks.Average() < 50)
                {
                    Console.WriteLine("Failed");

                }
                else if (Marks[i] > 35 && Marks.Average() < 50)
                    Console.WriteLine("Failed");
                else
                    Console.WriteLine("Pass");
            }
        }
        public void DisplayDetails()
        {
            Console.WriteLine("Roll No:{0} \t Name {1} \t Class {2} \t Sem {3} \t Branch {4}", RollNo, Name, Class, Sem, Branch);
            // Console.WriteLine("RollNumber" + RollNo + "Name" + Name + "Class" + Class + "Sem" + Sem + "Branch" + Branch);
        }


    }


    //Client Application
    public class StudentProgram
    {
        static void Main()
        {
            //Student student = new Student(102,"Abi","A","First","CSE");

            //Student student = new Student();  //instatiating a Student class object
            //Default constructor is called if it is existing
            //Automatically calling an overloaded contructor
            Student student = new Student(103, "Kanav");
            Student abc;//instance of Student class is declared
                        //abc.AcceptStudent();//Error if we use an instance without initialising 
            student.AcceptStudent();
            student.AcceptStudent(10); //Method with only int will be called....if it is not there then 
                                       //it will call method below which takes int and default value for float
            student.AcceptStudent(10, 79.89f);//Method with int and float will be called
            Console.WriteLine("The default values are displayed before calling AcceptStudent");
            student.DisplayDetails();//Before contructor was created the values were null

            Console.WriteLine("The values is passed thru AcceptStudent Method");
            student.AcceptStudent(102, "Abi", "A", "First", "CSE");
            student.DisplayDetails();

            //int[] marks = new int[5] { 20, 90, 40, 80, 100 };
            // student.DisplayResult(marks);

            student.DisplayResult(new int[] { 35, 50, 40, 60, 95 });

            abc = new Student();//initializing when needed
            abc.AcceptStudent();
            Console.WriteLine("The default values is passed thru Constructor");
            abc.DisplayDetails();
            new Student().DisplayDetails();//Anonymous instance which can be used only once

            Console.ReadLine();
        }
    }
}