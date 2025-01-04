using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part23_Indexes
    {
        public Part23_Indexes() { }

        private string[] names = new string[12];
        public string this[int i]
        {
            get { return names[i]; }
            set { names[i] = value; }
        }
    }
}
