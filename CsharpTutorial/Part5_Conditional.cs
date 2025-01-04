using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part5_Conditional
    {
        public Part5_Conditional() { }

        public void EligibleVote()
        {
            try
            {
                Console.WriteLine("Enter Your Age :");
                int age = Int32.Parse(Console.ReadLine());
                if (age != 0 && age >= 18)
                {
                    Console.WriteLine($"Your age is {age} eligible for Vote..");
                }
                else if (age<18)
                {
                    Console.WriteLine($"Your age is {age} you need to wait for {18-age} year/s");
                }
                else
                {
                    Console.WriteLine("Your are Not Eligible to Vote");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally 
            { 
                Console.WriteLine("The Eligible Voter Program Ends"); 
            }
        }

        public void NumberProgram()
        {
            Console.WriteLine("Enter the Number :");
            int n=Int32.Parse(Console.ReadLine());
            switch (n)
            {
                case 0:
                    Console.WriteLine("Number is 0");
                    break;
                case 1:
                    Console.WriteLine("Number is 1");
                    break;
                case 2:
                    Console.WriteLine("Number is 2");
                    break;

                case 3:
                    Console.WriteLine("Number is 3");
                    break;
                default:
                    Console.WriteLine("Out of Scope");
                    break;
            }
        }
    }
}
