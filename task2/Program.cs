using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {

        static double ConvertKmToMph(double kilometersPerHour)
        {
            return kilometersPerHour * 0.621371; 
        }



        static int ConvertMinutes(int hours, int minutes)
        {
            return (hours * 60) + minutes; 
        }



        static (int hours, int minutes) ConvertHoursAndMinutes(int totalMinutes)
        {
            int hour = totalMinutes / 60; 
            int minute = totalMinutes % 60; 
            return (hour, minute); 
        }
        static void Main(string[] args)
        {
            //1 - Write a C# program that accepts a double input and converts it into an int. Display both values.
            //    •	Example:
            //            Input: 9.8
            //    Output:
            //            Double: 9.8
            //    Converted Int: 9

            Console.WriteLine("Enter double value ");
            double num1=Convert.ToDouble(Console.ReadLine());
            int num2=(int)num1;
            Console.WriteLine($"double :{num1}");
            Console.WriteLine($"integer :{num2}");



            //2 - Write a program that uses a Convert.ToString() method to convert a number into a string and concatenate it with a sentence.
            //    Example:
            //    Input: 25
            //    Output: "Your number is: 25"

            Console.WriteLine("Enter number");
            int num3=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("your number is :"+num3 );



            //3 - Create a string with a sentence. Use ToUpper() and ToLower() to display the uppercase and lowercase versions of the string.
            //    Input: "C# is fun!"
            //    Output:
            //            Uppercase: C# IS FUN!
            //    Lowercase: c# is fun!

            string st= "C# is fun!";
            string uppercase = st.ToUpper();
            string lowercase = st.ToLower();

            Console.WriteLine($"Original: {st}");
            Console.WriteLine($"Uppercase: {uppercase}");
            Console.WriteLine($"Lowercase: {lowercase}");



            //4 - Write a program that takes a user's full name as input and prints:
            //    The first name.
            //    The last name.
            //    The length of the full name.
            //    •	Example:
            //            Input: "John Doe"
            //    Output:
            //                First Name: John
            //                Last Name: Doe
            //                Total Characters: 8

            Console.Write("Enter your first  name: ");
            string ferstName= Console.ReadLine();
            Console.Write("Enter your last  name: ");
            String lastName= Console.ReadLine();
            String fullName=ferstName+lastName;
            Console.WriteLine("full name :"+fullName);
            Console.WriteLine("length:"+fullName.Length);


            //5 - Write a program that accepts two integers and prints the smaller of the two.
            //    Input: 5, 9
            //    Output: "Smaller Number: 5"


            Console.Write("Enter first number: ");
            int num4= Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num5 = Convert.ToInt32(Console.ReadLine());
            int smallerNumber = num4 < num5 ? num4 : num5;

            Console.WriteLine($"Smaller Number: {smallerNumber}");

            //Write a method that converts kilometers per hour to miles per hour. Use this method in a program to convert and display the result.
            //    Input: 15 km / h
            //    Output: "9.320568 mph"


            double kmh = 15; 
            double mph = ConvertKmToMph(kmh); 
            Console.WriteLine($"{mph:F6} mph");




            //7 - Write a method that takes hours and minutes as input and returns the total number of minutes.
            //    Input: 5 hours, 37 minutes
            //    Output: "Total: 337 minutes"


            int hours = 5;   
            int minutes = 37; 
            int totalMinutes = ConvertMinutes(hours, minutes); 
            Console.WriteLine($"Total: {totalMinutes} minutes");


            //8 - Write a method that accepts minutes as input and calculates the total number of hours and minutes.
            //    •	Input: 546 minutes
            //    •	Output: "9 Hours, 6 Minutes"


            int inputMinutes = 546; 

            var (hour, minute) = ConvertHoursAndMinutes(inputMinutes); 
            Console.WriteLine($"{hour} Hours, {minute} Minutes");


            //9 - Compare Two Numbers
            //    Write a program that prints:
            //                "Equal" if two numbers are the same.
            //    "Greater" if the first is greater.
            //    "Smaller" if the second is greater.
            //    Use only comparison and ternary operators.
            //    •	Input: 10, 20
            //    •	Output: "Smaller"Sum of Digits
            //    Write a program that calculates the sum of the digits of a number using arithmetic operators and loops(no conditionals).
            //    Input: 123
            //    Output: "Sum of digits: 6"


            int num6 = 10; 
            int num7 = 20;

            string result = (num6 == num7) ? "Equal" : (num6 > num7) ? "Greater" : "Smaller";
            Console.WriteLine(result);





            //10 - Reverse a Number
            //    Write a program that reverses a number using arithmetic operators and loops.
            //    Input: 1234
            //    Output: "Reversed Number: 4321"

            int number = 1234; 
            int reversedNumber = 0;

            while (number > 0) 
            {
                int digit = number % 10; 
                reversedNumber = (reversedNumber * 10) + digit; 
                number /= 10; 
            }

            Console.WriteLine($"Reversed Number: {reversedNumber}");

            //11 - Check Divisibility
            //    Write a program to check if a number is divisible by another number using logical and arithmetic operators. Return a message "Divisible" or "Not Divisible".
            //    Input: 25, 5
            //    Output: "Divisible"

            int number2 = 25;
            int divisor = 5; 
            string result2 = (divisor != 0 && number2 % divisor == 0) ? "Divisible" : "Not Divisible";

            Console.WriteLine(result2);



            //12 - Find the Middle Value
            //    Write a program to find the middle value of three numbers using arithmetic and comparison operators.
            //    Input: 15, 20, 10
            //    Output: "The middle value is: 15"

                int a = 15; 
                int b = 20; 
                int c = 10;

                int middle;
                if ((a > b && a < c) || (a < b && a > c))
                {
                    middle = a; 
                }
                else if ((b > a && b < c) || (b < a && b > c))
                {
                    middle = b; 
                }
                else
                {
                    middle = c; 
                }

                Console.WriteLine($"The middle value is: {middle}"); 


            }






    }
    }

