using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTutorial
{
    public interface ICategory
    {
        public bool Add();

        public bool Remove();
    }
    public interface IPriceDeails
    {
        public void valuecheck();
    }
    public class Category : ICategory,IPriceDeails
    {
        public bool Add()
        {
            return false;
        }
        public bool Remove()
        {
            return false;
        }
        public void valuecheck() 
        {
            Console.WriteLine("This is Price value");
        }

        public void Print()
        {
            Console.WriteLine("This is from Printing");
        }
    }
}
