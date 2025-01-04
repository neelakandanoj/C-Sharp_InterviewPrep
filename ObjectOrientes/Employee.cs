using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class Employee
    {
        public string FirstName;
        public string LastName;
        public string EMail;

        public void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName}");
        }
    }
}
