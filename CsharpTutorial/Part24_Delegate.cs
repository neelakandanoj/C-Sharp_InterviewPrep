using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{


    public static class Part24_Delegate
    {
        public delegate int SUMDel(int a, int b);

        public static int Sum(int a,int b)
        {
            return a + b;
        }
        public static void PrintSum(int a, int b, Func<int, int, int> sUMDEL)
        {
            Console.WriteLine($"Sum of {a} + {b} is {sUMDEL(a, b)}");
        }


    }
    

}
