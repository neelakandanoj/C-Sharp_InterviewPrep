using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public abstract class Abstract_Shape
    {
        public Abstract_Shape() { }

        public int d1, d2;

        public Abstract_Shape(int d1, int d2) 
        {
            this.d1 = d1;
            this.d2 = d2;
        }

        public abstract int area();

        
        


    }
}
