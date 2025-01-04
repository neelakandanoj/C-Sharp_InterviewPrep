using ObjectOrientedProgramming;

namespace ObjectOrientes
{
    
    public class Program
    {
        public static void Display(int emp) //Static method
        {
            Console.WriteLine($"Emp Count {emp}");
        }

        public void paint(int x, int y) //instance method
        {
            Console.WriteLine($"Line exists {x} to {y}");
           //class name, Method
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //Static method calling
            Display(10);

            //Instance Method need to initialize object
            Program e = new Program();
            e.paint(10, 12);
            

            FullTimeEmployee FullEmp = new FullTimeEmployee();
            FullEmp.FirstName = "Neelakandan";
            FullEmp.LastName = "OJ";
            //FullEmp.Yearlysalary = 400000.00f;
            FullEmp.PrintFullName();
            
            ParttimeEmployee ParttimeEmp = new ParttimeEmployee();
            ParttimeEmp.FirstName = "Part";
            ParttimeEmp.LastName = "time";
            ParttimeEmp.Monthlysalary = 8000.00f;
            ParttimeEmp.PrintFullName();
            //ParttimeEmp.Yearlysalary = '0';

            Employee FM=new Employee();
            FM.FirstName = "OJ";
            FM.LastName = "LL";
            FM.PrintFullName();
            Console.ReadKey();
        }
    }
}
