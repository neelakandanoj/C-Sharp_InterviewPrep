using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part3_TypeCasting
    {
        public static int a = 5;
        public static double d = a; //implicit converstion

        public void TypeConversion()
        {
            int a = 10;
            double d = a;
            Console.WriteLine("This type is Int to Double :"+d);

            float c = 23.89f;
            int v =(int)Convert.ToInt64(c);
            Console.WriteLine("This type is float to Int :"+v);

            double du = 7865567688888;
            int j=(int)Convert.ToInt64(du);
            Console.WriteLine("this type is double to int :" + j);


        }



    }
}
