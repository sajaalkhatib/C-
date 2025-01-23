using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5
{
    internal class Program
    {

        class Vehicle
        {
            public String Model { get; set; }
            public String Brand { get; set; }

            public void Start()
            {
                Console.WriteLine($"{Model} , {Brand}");
            }
        }


        class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
            public void print()
            {
                Console.WriteLine($"{Model} , {Brand} ,{NumberOfDoors}");
            }
        }
        static void Main(string[] args)
        {

            Car car = new Car();
            car.Brand = "weas2";
            car.Model = "BMW";
            car.NumberOfDoors = 3;
            car.print();


        }
    }
}
