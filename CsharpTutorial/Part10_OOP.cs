using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{

    public class Part10_OOP
    {

        public class Car
        {
            //Empty constructor
            public Car() { }

            //fields or data members
            public string Make;
            public string Model;
            public string Name;
            public int year;
            public int price;

            //Methods
            public void Start()
            {
                Console.WriteLine("Car is Started.");
            }

            public void Stop()
            {
                Console.WriteLine("Car is stoped.");
            }

            public void Run()
            {
                Console.WriteLine("Car is Running.");
            }

        }
    }
}
