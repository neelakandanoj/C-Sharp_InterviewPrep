using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part12_Constructor
    {

        public int Age;
        public string name;
        //Default Constructor ctor
        public Part12_Constructor() 
        {
            Console.WriteLine("Default Constructor Called..");
        }

        public Part12_Constructor(string name,int Age)
        { 
            this.name = name;
            this.Age = Age;
            Console.WriteLine("Parameterized Constructor..");
        }
        public void Display()
        {
            Console.WriteLine($"Name : {name}, Age : {Age}");
        }

        
    }
}
