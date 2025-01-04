namespace OOP_Full
{

    
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /*
            Student s = new Student
            {
                roll = 10,
                name = "Ram",
                score = 345
            };

            Student t = new Student(11,"Krish",500);

            Student p = new Student();
            p.SetData();
            p.GetData();

            Console.WriteLine(s.roll+" "+s.name+" "+s.score);


            //Inheritance
            Console.WriteLine("This Part is from INheritance.");
            SchoolStudent ss=new SchoolStudent();
            ss.SetData();
            ss.GetData();

            //Inheritance from Constructor
            Console.WriteLine("From the Constructor for Inheritance");
            SchoolStudent sc=new SchoolStudent(1,"sri",456,4,"A");
            sc.GetData();

            //MultiLevel Inheritance
            HRStudent hR=new HRStudent();
            hR.SetData();
            hR.GetData();

            HRStudent h1 = new HRStudent(1,"Ram",232,1,"B","U");
            h1.GetData();


            Abstract_Shape v = new Abstract_Rectange();
            v.area();
            
            //This is for credit
            IMyInterfacecs myInterfacecs = new Product();
            myInterfacecs.SetData();
            myInterfacecs.GetData();
            

            Console.WriteLine("This is for PRice get/set");
            IMyInterfacecs myInterfacec = new Customer();
            myInterfacec.SetData();
            myInterfacec.GetData();
            */

            //Static member
            Student s1= new Student(1,"Neel",786);
            s1.GetData();
            Student s2 = new Student();
            Console.WriteLine(Student.totmark);

            Static_circle circle = new Static_circle();
            circle.r = 12;
            Console.WriteLine(circle.Area());

            Console.WriteLine(Static_circle.staticArea(12));

            Console.ReadKey();
            
        }
    }
}
