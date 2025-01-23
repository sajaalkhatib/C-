using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_6
{
    internal class Program
    {

        class Calculator
        {
            public int Add(int a, int b)
            {
                return a + b;
            }

            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }

            public double Add(double a, double b)
            {
                return a + b;
            }
        }


        class Shape
        {
            public virtual void Draw()
            {
                Console.WriteLine("Drawing a Shape.");
            }
        }

        class Circle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Circle.");
            }
        }

        class Rectangle : Shape
        {
            public override void Draw()
            {
                Console.WriteLine("Drawing a Rectangle.");
            }
        }




        abstract class Animal
        {
            public abstract void MakeSound();

            public void Sleep()
            {
                Console.WriteLine("Animal is sleeping.");
            }
        }

        class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Dog barks.");
            }
        }

        class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Cat meows.");
            }
        }



        interface IPlayable
        {
            void Play();
        }

        class Guitar : IPlayable
        {
            public void Play()
            {
                Console.WriteLine("Playing the guitar.");
            }
        }

        class Piano : IPlayable
        {
            public void Play()
            {
                Console.WriteLine("Playing the piano.");
            }
        }


        static void Main(string[] args)
        {
            //task1
            Calculator calc = new Calculator();
            int sum=calc.Add(1, 2);
            Console.WriteLine(sum);
            int sum1=calc.Add(2, 3,4);
            Console.WriteLine(sum1);
            double sum2=calc.Add(5.5,5.5);
            Console.WriteLine(sum2);


           //task 2
            Shape shape1 = new Circle();    
            Shape shape2 = new Rectangle();  
            shape1.Draw();  
            shape2.Draw();

            //task3
            Animal dog = new Dog();
            Animal cat = new Cat();

            dog.MakeSound();
            dog.Sleep();

            cat.MakeSound();
            cat.Sleep();

            //task 4
            IPlayable guitar = new Guitar();
            IPlayable piano = new Piano();
            guitar.Play();
            piano.Play();


        }
    }
}
