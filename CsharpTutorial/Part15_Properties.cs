using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public class Part15_Properties
    {
        private string Name;
        private double price;

        public double Price 
        {  
            get { return price; } 
            set 
            {
                if (value < 0)
                {
                    throw new Exception("Cant have negative value");
                }
                
                price = value; 
            } 
        }
    }
}
