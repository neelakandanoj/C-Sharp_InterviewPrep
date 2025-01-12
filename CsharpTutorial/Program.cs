using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace CsharpTutorial
{
    public class Program
    {
        public readonly string name="8";

        public Program(string name) 
        {
            this.name = name;
        }

        delegate void Calculator(int x, int y);

        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void PrintSum(int a, int b, Func<int, int, int> sUMDEL)
        {
            Console.WriteLine($"Sum of {a} + {b} is {sUMDEL(a, b)}");
        }

        public static void Greeting(string msg, Action<string> greethandler) 
        {
            greethandler(msg);
        }

        static void Main(string[] args)
        {
            
            #region Variable's
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Learning C# Programming");

            DateTime dateTime = DateTime.Now;
            Console.WriteLine(dateTime.ToString());

            const int v = 1;
            int a = 2;
            a = 4;
            //v = 2;
            Console.WriteLine(v);

            

            Program p = new Program("Neelakandan");
            Console.WriteLine($"This part from readonly {p.name}");
            #endregion

            #region Type Casting
            Part3_TypeCasting p3 =new Part3_TypeCasting();
            p3.TypeConversion();


            #endregion

            #region Operators
            Part4_Operator p4 = new Part4_Operator();
            Console.WriteLine("Addition :"+p4.Addition(23, 1));
            Console.WriteLine("Substraction :"+p4.Substraction(23, 1));

            #endregion
            
            #region Conditional Statement
            Part5_Conditional p5 = new Part5_Conditional();
            p5.EligibleVote();

            p5.NumberProgram();

            #endregion
            
            #region Looping
            Part6_Looping p6 = new Part6_Looping();
            p6.EgForLoop();
            p6.EgWhileLoop();
            p6.EgDoWhile();
            #endregion
            
            #region Jump Statement
            Part7_Jumping p7 =new Part7_Jumping();
            p7.EgBreak();
            p7.EgContinue();
            p7.EgGoto();
            #endregion
            
            #region String

            Part8_String p8 = new Part8_String();
            p8.EgString();
            #endregion
            
            #region Practice Problem
            Part9_Practice p9 = new Part9_Practice();
            p9.patten();
            #endregion           

            #region Object Oriented Programming
            //Part10_OOP p10 = new Part10_OOP();
            Part10_OOP.Car c = new Part10_OOP.Car();
            c.Model = "xyz";
            c.Make = "Mahamdra";
            c.year = 2032;
            c.Name = "ooi";
            c.price = 100000;
            Console.WriteLine($"model : {c.Model}, Name : {c.Name}, Make :{c.Make}");
            c.Start();
            c.Run();
            c.Stop();
            #endregion
            
            #region Encapsulation
            Part11_Encapsulation p11=new Part11_Encapsulation();
            
            #endregion
            
            #region Constructor
            Part12_Constructor p12=new Part12_Constructor();
            p12.Display();
            
            Part12_Constructor p12_1=new Part12_Constructor("Nee",2);
            p12_1.Display();

            #endregion
            
            #region Inheritance

            Part13_Inheritance.Employee employee = new Part13_Inheritance.Employee(1,"John");
            employee.DisplayEmployee();
            Part13_Inheritance.Programmer pm =new Part13_Inheritance.Programmer(2,"ikol");
            pm.DisplayEmployee();
            Part13_Inheritance.Manager m = new Part13_Inheritance.Manager(3, "rahul");
            m.DisplayEmployee();
            pm.GetCoffee();
            Console.WriteLine("This is calling from child class");
            m.DisplayEmployee();
            m.GetCoffee();
            m.AssignTask();
            
            #endregion

            #region Polymorphism
            Part14_Polymorphism part14 = new Part14_Polymorphism();
            //Method Overloading
            Console.WriteLine("This is Method Overloading Part");
            part14.Sum(10,10);
            part14.Sum(10,10,10);

            //Method Overriding
            Console.WriteLine("This is Method Overriding Part");
            //Base class overriding the derived class
            Shape sh = new Shape();
            sh.Draw();
            
            Shape circle = new Circle();
            circle.Draw();
            
            Shape square = new Square();   
            square.Draw();
            #endregion
            
            #region Properties
            Part15_Properties part15 = new Part15_Properties();
            part15.Price = -90;
            Console.WriteLine(part15.Price);
            #endregion
            
            #region Static Members
            Part16_Static part16 = new Part16_Static();
            Part16_Static.Sum(10,21);
            part16.Print();
            Part16_Static p1= new Part16_Static();
            p1.Print();
            Part16_Static p1_1 = new Part16_Static();
            p1_1.Print();

            #endregion
            
            #region Exception
            Part17_Exception part17 = new Part17_Exception();
            part17.EgTry();

            #endregion
            
            #region Abstract
            Part18_Abstract part18_Abstract = new Part18_Abstract();
            part18_Abstract.Print();
            part18_Abstract.Draw();
            part18_Abstract.Draw2();
            #endregion
            
            #region Interface
            ICategory cm= new Category();
            Console.WriteLine("This is from Adding . "+cm.Add());
            Console.WriteLine("This from Remove. "+cm.Remove());
            //c.Print();//Cannot accesiable becoz PRint method interface not created.

            IPriceDeails pc = new Category();
            pc.valuecheck();
            #endregion

            #region Boxing and Unboxing
            int ak = 5;
            object obj = ak;
            Console.WriteLine(obj);

            int b=(int)obj;
            Console.WriteLine(b);
            
            #endregion
            
            #region Extension Method
            //Part20_Extenstion_Method part20 = new Part20_Extenstion_Method();
            string s = "Hello";
            Console.WriteLine(s.MyCount());

            #endregion
            
            #region Enums
            Console.WriteLine(Weeks.Friday);
            #endregion
            
            #region Array's

            int[] arr1 = new int[5];
            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;
            arr1[3] = 4;
            arr1[4] = 5;

            foreach (int i in arr1) 
            {
                Console.WriteLine(i);
            }

            int[] arr = new int[] { 1,2,3,4,5};
            Console.WriteLine(arr);

            Part21_Array[] p21 = {

                new Part21_Array { Name="Apple",Price=231 },
                new Part21_Array{Name="Orange",Price=23}
            };

            int[] ass = { 1,2,4,6};

            #endregion
            
            #region Collections
            Part23_Indexes part23 = new Part23_Indexes();
            part23[0] = "Apple";
            part23[1] = "Orange";

            for (int i = 0; i < 10; i++) 
            { 
                Console.WriteLine(part23[i]);
            }
            #endregion
            
            #region Delegates and Multicast Delegate's
            Calculator calc = new Calculator(Add);
            calc = calc+ Mul;
            calc(20, 30);

            //Anonymous
            Calculator cal = delegate (int a, int b)
            {
                Console.WriteLine("This is from Anonymous Delegate "+a + b);
            };
            cal(20, 30);

            Func<int, int, int> sumhandler = (a, b) =>
            {
                return a + b;
            };
            PrintSum(2, 4, sumhandler);

            Action<string> greethandler=(msg)=> 
            { 
                Console.WriteLine(msg); 
            };
            Greeting("Hello",greethandler);

            #endregion

            Console.ReadKey();
        }
    }
}
