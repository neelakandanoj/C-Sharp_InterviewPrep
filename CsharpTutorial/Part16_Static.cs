using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part16_Static
    {
        static int count = 0;

        public Part16_Static()
        {
            count++;
        }
        public static int Sum(int a,int b)
        {
            return a + b;
        }

        public void Print()
        {
            Console.WriteLine(count);
        }

    }

    public static class Utility
    {
        public static void sendEmail()
        {
            Console.WriteLine("Sending EMail");
        }
    }
}
