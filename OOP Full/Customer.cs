using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class Customer:IMyInterfacecs
    {
        public int Id { get; set; } 

        public string Name { get; set; }

        public int credit { get; set; }

        public void GetData()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("credit " + credit);
        }

        public void UpdateData() 
        {
            Console.WriteLine("Enter the Id: ");
            Id=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the credit :");
            credit = int.Parse(Console.ReadLine());
       
        }

        public void SetData()
        {
            Console.WriteLine("Enter the Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the credit :");
            credit = int.Parse(Console.ReadLine());
        }
    }
}
