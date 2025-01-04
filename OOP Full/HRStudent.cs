using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class HRStudent:SchoolStudent
    {
        public string group;

        public HRStudent() { }

        public HRStudent(int roll,string name,int score, int std, string sec,string group)
        {
            this.group = group;
        }

        public override void SetData()
        {
            base.SetData();
            Console.WriteLine("Enter the Group: ");
            group = Console.ReadLine();
        }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Group : {group}");
        }
    }

}
