using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public static class Part20_Extenstion_Method
    {
        public static int MyCount(this string s)
        {
            return s.Length;
        }
    }
}
