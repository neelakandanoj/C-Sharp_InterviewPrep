using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class Abstract_Rectange:Abstract_Shape
    {
        public override int area()
        {
            return d1 * d2;
        }

        public int get_peri()
        {
            return 2;
        }
    }
}
