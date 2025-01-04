using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class Product:IMyInterfacecs
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int price { get; set; }

        public void GetData()
        {
            Console.WriteLine("Id :" + Id);
            Console.WriteLine("Name :" + Name);
            Console.WriteLine("price " + price);
        }

        public void UpdateData()
        {
            Console.WriteLine("Enter the Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the price :");
            price = int.Parse(Console.ReadLine());

        }

        public void SetData()
        {
            Console.WriteLine("Enter the Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Name :");
            Name = Console.ReadLine();
            Console.WriteLine("Enter the price :");
            price = int.Parse(Console.ReadLine());
        }
    }
}
