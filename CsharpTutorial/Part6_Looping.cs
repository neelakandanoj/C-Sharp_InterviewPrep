using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part6_Looping
    {
        public void EgWhileLoop()
        {
            int num = 10;
            while (num > 0)
            {
                Console.WriteLine("While Loop :"+ num);
                num--;

            }
            Console.WriteLine("***************************************");
        }
        public void EgForLoop() 
        {
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("For Loop :"+i);
            }
            Console.WriteLine("****************************************");
        
        }

        public void EgDoWhile() 
        {
            int n = 2;
            do
            {
                Console.WriteLine("Even NUmber 0 to 100: " + n);
                n += 2;
            }
            while (n < 100); 

        }
    }
}
