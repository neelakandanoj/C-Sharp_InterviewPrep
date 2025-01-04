using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedProgramming
{
    public class FullTimeEmployee:Employee
    {
        public string Yearlysalary;
        public new void PrintFullName()
        {
            Console.WriteLine($"{FirstName} {LastName} Contractor..");
        }

    }

    public class ParttimeEmployee:FullTimeEmployee
    {
        public float Monthlysalary { get; set; }
    }
}
