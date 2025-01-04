using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part13_Inheritance
    {
        public class Employee
        {
            public int Id;
            public string Name;

            public Employee(int id, string name)
            {
                Id = id;
                Name = name;
            }
            public Employee() : base() { }

            public void DisplayEmployee()
            {
                Console.WriteLine("This is from Parent class");
                Console.WriteLine($"Name {Name}, Id {Id}");
            }

        }
        public class Programmer : Employee
        {
            public Programmer(int id, string name) : base(id, name) { }

            public Programmer() : base() { }
            public void GetCoffee()
            {
                Console.WriteLine("This is child class");
            }
        }

        public class Manager : Programmer
        {
            public Manager(int id, string name) : base(id, name) { }

            public Manager() : base() { }
            public void AssignTask()
            {
                Console.WriteLine("Assigning class..");
            }

        }

    }
    
}
