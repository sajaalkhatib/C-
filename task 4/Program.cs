using System;
using System.Security.Claims;

namespace Task4
{
    internal class Program
    {
        class Student
        {
            
            private string name;//fildes
            private int age; //fildes 
            private int studentID; //fildes

            // Public properties with getter and setter
            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Age
            {
                get { return age; }
                set
                {
                    //  if ststement Validate age within range
                    if (value >= MinAge && value <= MaxAge)
                        age = value;
                    else
                        throw new ArgumentException($"Age must be between {MinAge} and {MaxAge}");
                }
            }

            public int StudentID
            {
                get { return studentID; }
                set { studentID = value; }
            }

           
            public string Email { get; set; }// auto implementauion property 
            //constant value 
            public const int MinAge = 18;
            public const int MaxAge = 40;

            // Constructor with parameter 
            public Student(string name, int age, int studentID)
            {
                Name = name; //  property 
                Age = age;
                StudentID = studentID;
            }

            // Method student details
            public void getDetails()
            {
                Console.WriteLine($"Name: {Name}, Age: {Age}, Student ID: {StudentID}");
            }
        }

        static void Main(string[] args)
        {
            //
            Student student1 = new Student("Saja", 23, 24);
            student1.Email = "saja@example.com"; 
            student1.getDetails(); 

            Student student2 = new Student("batool", 25, 25);
            student2.Email = "batool@example.com"; 
            student2.getDetails();


        //Class: Blueprint for creating objects, defining properties and methods.
        //Object: Instance of a class that holds data and can perform actions.
        //Difference: Class is a template; object is a concrete instance.
        //OOP Principles:
        //Encapsulation: Bundling data and methods; restricting access.
        //Abstraction: Hiding details; exposing only necessary features.
        //Inheritance: Creating new classes from existing ones.
        //Polymorphism: Treating different classes as the same type.
        //Property: An attribute of an object.
        //Field: A variable in a class that stores data.
        //Constructor: Method called when an object is created to initialize it.
        //Encapsulation: Wrapping data and methods together; controlling access.

        }
    }
}
