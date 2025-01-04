using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part8_String
    {
        public Part8_String() 
        {

        }

        public void EgString()
        {
            string a = "Hello";
            Console.WriteLine(a.Length);
            Console.WriteLine(a.GetType());
            Console.WriteLine(a[0]);
            Console.WriteLine((a.Length-1));

        }
    }
}
