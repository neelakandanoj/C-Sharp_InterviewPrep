using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class SchoolStudent:Student
    {
        public int std;
        public string sec;

        public SchoolStudent(int roll,string name,int score,int std,string sec)
        {
            this.roll = roll;
            this.name = name;
            this.score = score;
            this.std = std;
            this.sec = sec;
        }

        public SchoolStudent() :base()
        {
            
        }  
        public override void SetData()
        {
            base.SetData();
            Console.WriteLine("Enter the std :");
            std=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the sec :");
            sec = Console.ReadLine();
        }

        public override void GetData()
        {
            base.GetData();
            Console.WriteLine($"Standard : {std}, Section : {sec}");
        }
    }
}
