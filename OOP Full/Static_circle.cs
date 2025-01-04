using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public  class Static_circle
    {
        public int r;
        public static float pi = 3.14f;

       

        public float Area()
        {
            return pi * r * r;
        }

        public static float staticArea(int r) 
        {
            return pi * r * r; 
        }

    }
}
