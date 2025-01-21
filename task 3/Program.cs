using System;
using System.Security.Claims;

namespace task_3
{
    internal class Program
    {
        static int Smallest(int[] nums)
        {
            Array.Sort(nums);
            int secondSmallest = nums[0];

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] != secondSmallest)
                {
                    return nums[i];
                }
            }

            return nums[1]; // Default return if all numbers are the same
        }

        static int CalculateFactorial(int n)
        {
            int result = 1;

            for (int i = 1; i <= n; i++)
            {
                result *= i;
            }

            return result;
        }

        static bool IsPrime(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        static int FindLargest(int[] nums)
        {
            int largest = nums[0];
            foreach (int i in nums)
            {
                if (i > largest)
                {
                    largest = i;
                }
            }
            return largest;
        }

        static void PrintNumberPattern(int n)
        {
            int number = 1;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(number + " ");
                    number++;
                }
                Console.WriteLine();
            }
        }
        static void pattern()
        {
          for(int i = 1; i <= 4; ++i)
            {
                for(int j = 1; j <= 4; ++j)
                {
                    Console.WriteLine(" ");
                }
                for(int k = 1; k <= 4; ++k)
                {
                    Console.WriteLine("*");
                }
                Console.WriteLine( " ");
            }
           Console.ReadLine();
        }


        class Room
        {
       
            public const string HotelName = "Grand Stay Hotel";

         
            public int roomNumber;
            public string roomType;
            public double pricePerNight;
            public bool isBooked;

            public void SetRoomDetails(int number, string type, double price, bool booked)
            {
                roomNumber = number;
                roomType = type;
                pricePerNight = price;
                isBooked = booked;
            }

          
            public void DisplayDetails()
            {
                Console.WriteLine($"Hotel Name: {HotelName}");
                Console.WriteLine($"Room Number: {roomNumber}");
                Console.WriteLine($"Room Type: {roomType}");
                Console.WriteLine($"Price Per Night: {pricePerNight:C}");
                Console.WriteLine($"Is Booked: {(isBooked ? "Yes" : "No")}");
                Console.WriteLine(new string('-', 30));
            }
        }

        static void Main(string[] args)
        {
            // 1 - Check if the number is even or odd
            Console.Write("Enter an integer: ");
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                Console.WriteLine($"{number} is {(number % 2 == 0 ? "even" : "odd")}.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

            // 2 - Find the second smallest number
            int[] numbers = new int[5];
            Console.WriteLine("Enter five numbers:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int secondSmallest = Smallest(numbers);
            Console.WriteLine($"The second smallest number is: {secondSmallest}");

            // 3 - Calculate factorial
            Console.Write("Enter a number to calculate its factorial: ");
            int num1 = int.Parse(Console.ReadLine());
            int factorial = CalculateFactorial(num1);
            Console.WriteLine($"The factorial of {num1} is: {factorial}");

            // 4 - Print prime numbers between two integers
            Console.Write("Enter start number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Enter end number: ");
            int end = int.Parse(Console.ReadLine());
            Console.Write("Prime numbers: ");
            for (int n1 = start; n1 <= end; n1++)
            {
                if (IsPrime(n1))
                {
                    Console.Write(n1 + " ");
                }
            }
            Console.WriteLine();

            // 5 - Find the largest number in an array
            int[] array = { 3, 1, 4, 1, 5, 9 };
            int largest = FindLargest(array);
            Console.WriteLine($"The largest number in the array is: {largest}");


            //6- prints the following number pattern
            int n = 5;
            PrintNumberPattern(n);


            pattern();

            //Class && Object
            //Console.WriteLine("Enter details for 2 rooms:");

            //Room[] rooms = new Room[2];

            //for (int i = 0; i < rooms.Length; i++)
            //{
            //    Console.WriteLine($"\nRoom {i + 1}:");
            //    Console.Write("Enter Room Number: ");
            //    int roomNumber = int.Parse(Console.ReadLine());

            //    Console.Write("Enter Room Type (e.g., Single, Double, Suite): ");
            //    string roomType = Console.ReadLine();

            //    Console.Write("Enter Price Per Night: ");
            //    double pricePerNight = double.Parse(Console.ReadLine());

            //    Console.Write("Is the Room Booked? (true/false): ");
            //    bool isBooked = bool.Parse(Console.ReadLine());

            //    rooms[i] = new Room();
            //    rooms[i].SetRoomDetails(roomNumber, roomType, pricePerNight, isBooked);
            //}

            //Console.WriteLine("\nRoom Details:");
            //foreach (var room in rooms)
            //{
            //    room.DisplayDetails();
            //}



            //(optional)

        }
    }
}