using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //1 - Create console application that read string from user and print the same string
            Console.WriteLine("enter name: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("you entered: " + userInput);



            //2 - Define variables with kind of
            //    a.Double
            //    b.String
            //    c.Char
            //    d.Bool
            //    e.Int
            //    f.Const
            //    Then display it in console application

            double x = 3.14;
            string y= "Hello, World!";
            char a= 'A';
            bool b = true;
            int z = 42;
            const string v = "saja saleh ali alkhatib";

            Console.WriteLine("Double: " + x);
            Console.WriteLine("String: " + y);
            Console.WriteLine("Char: " +a);
            Console.WriteLine("Bool: " +b);
            Console.WriteLine("Int: " + z);
            Console.WriteLine("Const: " + v);


            //3 - Define array with name car that hold more than 3 kinds on cars, then print all the cars with the array length.

            string[] cars = { "Toyota", "Honda", "Ford", "BMW" };
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }


            // Write a program in C that reads a first name, Lastname and year of birth and display the names and the year one after another sequentially.Go to the editor
            //    •	Input your firstname: Sami
            //    •	Input your lastname: Ali
            //    •	Input your year of birth: 1999
            //    •	Sami Ali 1


            Console.Write("firstname: ");
            string firstName = Console.ReadLine();
            Console.Write("lastname: ");
            string lastName = Console.ReadLine();
            Console.Write("birth: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstName} {lastName} {year}");



            //Write a program in C # to store elements in an array and print it. 
            //    •	Test Data :	
            //    •	Input 10 elements in the array :
            //    •	element - 0 : 1
            //    •	element - 1 : 1
            //    •	element - 2 : 2
            //    •	.......
            //    •	Expected Output :
            //    •	Elements in array are: 1 1 2 3 4 5 6 7 8 9 99


            string[] elements = new string[10];
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write($"element - {i} : ");
                elements[i] = Console.ReadLine();
            }
            Console.WriteLine("Elements in array are: " + string.Join(" ", elements));

            


        }
    }
}
