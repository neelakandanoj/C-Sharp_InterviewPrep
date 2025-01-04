using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class ParentClass
    {
        public ParentClass()
        {
            Console.WriteLine("Parent class Constructor");

        }
        public ParentClass(string name)
        {
            Console.WriteLine(name);
        }

        public String Name;
    }

    public class ChildClass : ParentClass
    {
        public ChildClass():base("Derived class controlling parent class")
        {
            Console.WriteLine("Child Class Constructor");
        }
    }
    

}
