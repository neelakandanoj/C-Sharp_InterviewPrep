using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part11_Encapsulation
    {
        private string name {  get; set; }

        private int age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("Invalid Age");
                }
            }
        }
    }
}
