using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part7_Jumping
    {
        public void EgBreak()
        {
            Console.WriteLine("This is from Break");
            for (int i = 0; i < 10; i++)
            {
                if (i ==10)
                {
                    break;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("*****************************************************");

        }

        public void EgContinue()
        {
            Console.WriteLine("This is from Continue");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("*****************************************************");
        }

        
        public void EgGoto()
        {
            Console.WriteLine("This is from GOTO");
            for (int i = 0; i < 10; i++)
            {
                if (i == 1)
                {
                    goto find;
                }
                Console.WriteLine(i);

            }
            Console.WriteLine("*****************************************************");

        find:
            Console.WriteLine("Jumping out of Loop using GoTo");

        }

    }
}
