using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Full
{
    public class Student
    {
        public int roll;
        public string name;
        public int score;
        public static int totmark;


        public Student() { }
        public Student(int roll, string name, int score)
        {
            this.roll = roll;
            this.name = name;
            this.score = score;
            totmark++;
        }

        public virtual void SetData()
        {
            Console.WriteLine("Enter Roll NUmber");
            roll=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter score :");
            score = int.Parse(Console.ReadLine());

        }

        public virtual void GetData()
        {
            Console.WriteLine($"RollNumber :{roll}, Name :{name}, score : {score}");
        }
    }

    
}
