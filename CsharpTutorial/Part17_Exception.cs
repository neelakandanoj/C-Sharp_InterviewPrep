using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part17_Exception
    {
        public Part17_Exception() { }

        public void EgTry()
        {
            try
            {
                int a = 10;
                int b = 0;
                Console.WriteLine(a / b);

            }
            catch(Exception e) 
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("I am from finally block");
            }
            Console.WriteLine("Divided successfully");
        }
    }
}
