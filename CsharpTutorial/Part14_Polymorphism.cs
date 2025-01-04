using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part14_Polymorphism
    {
        //Method overloading
        public void Sum(int a ,int b)
        {
            Console.WriteLine($"Sum is {a+b}");
        }
        public void Sum(int a, int b,int c)
        {
            Console.WriteLine($"Sum is {a + b + c}");
        }
    }

    internal class Shape
    {
        private string name;

        //Virtual in base class
        public virtual void Draw()
        {
            Console.WriteLine($"I am Drawing Shape {name}");
        }

    }
    class Circle : Shape
    {
        //override in Derived class
        public override void Draw()
        {
            Console.WriteLine("I am Drwing Circle");
        }
    }

    class Square : Shape
    {
        //override in Derived class
        public override void Draw()
        {
            Console.WriteLine("I am Drwing Square");
        }
    }

}
