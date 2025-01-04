using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace CsharpTutorial
{
    public abstract class Shape1
    {
        int x;

        public abstract void Draw();

        public abstract void Draw2();

        public void Print()
        {
            Console.WriteLine("Printing...");
        }
        
    }

    public abstract class Employee
    {
        int sal;
        public double GetMinSal()
        {
            return sal;
        }

        public abstract double calBonus();
    }

    public class Part18_Abstract : Shape1
    {
        public override void Draw()
        {
            Console.WriteLine("Draw1");
        }
        public override void Draw2()
        {
            Console.WriteLine("Draw2");
        }
    }
}
