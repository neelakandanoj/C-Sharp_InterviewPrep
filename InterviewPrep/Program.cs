using System.Collections;
using System.Runtime.InteropServices;
using InterviewPrep_2;
namespace InterviewPrep
{
    public class Program
    {
        public static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World!");
            Console.WriteLine("Please Enter Your Name");
            //var name=Console.ReadLine();
            //Console.WriteLine("Hi ! {0}, Welcome to Learning DOT Net Technology.",name);
            
            #region Variable's
            dynamic b = true;
            b = 0;
            double f = 98.900;
            float g= 0.0f;
            string name1 = "Neelakandan";
            string url = @"C:\\program\\dotnet\\traniing";
            Console.WriteLine("My Name is {0} {1}",name1,url);

            #endregion

            #region Operators
            int Numerator = 10;
            int denominator = 10;
            int result=Numerator/denominator;
            Console.WriteLine("Result {0}", result);

            //Ternary Operator
            bool Isnum10 =Numerator ==10 ? true : false;
            Console.WriteLine(Isnum10);
            

            int? i = null;
            bool? IsActive = null;

            int? Ticketsales = null;
            int AvailableTicket = Ticketsales ?? 0;
            Console.WriteLine("AvailableTicket "+ AvailableTicket);

            float changesdatatype = 98.00f;
            Console.WriteLine((changesdatatype));
            int v = Convert.ToInt32(changesdatatype);
            Console.WriteLine(v);
            #endregion

            #region Array
            int[] num= new int[10];
            for(int k =0; k < num.Length; k++)
            {
                num[k] = k;
            }

            foreach (int l in num) {
                Console.WriteLine("the element is {0}", l);            
            }
            #endregion

            #region Control Statement [If/Else, While, Do While, Break, continue, switch]

            Console.WriteLine("Enter the Age : ");
            int? age = 30; //i;nt.Parse(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Your Age is Greater than 18 Eligible to Vote");
            }
            else if (age < 18 & age !=0)
            {
                Console.WriteLine("You are too Young .");
            }
            else {
                Console.WriteLine("Not eligible");
            }


            Console.WriteLine("Enter the number :");
            int userNumber=int.Parse(Console.ReadLine());
            switch (userNumber)
            {
                case 0:
                    Console.WriteLine("Number is zero");
                    break;
                    
                case 1:
                    if (1==1)
                    {
                        Console.WriteLine("This is If clause");
                    }
                    Console.WriteLine("Number is one");
                    break;

                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Number 2,3,4");
                    break;
                default:
                    Console.WriteLine("Default Msg");
                    break;

            }
            int j = 10;
            while (j > 0){
                Console.WriteLine("While Loop " + j);
                j--;
            }
            
            int num1 = 0;
            do
            {
                Console.WriteLine("Do While Numbers: " + num1);
                num1++;
            }
            while (num1 > 10);

            int[] num2 = new int[10];
            ArrayList arrayList = new ArrayList();
            for (int k = 0; k < num2.Length; k++)
            {
                arrayList.Add(k);
                num2[k] = k;
            }
           

            foreach (int l in num2)
            {
                Console.WriteLine("For Each the element is {0}", l);
            }

            foreach(var l in arrayList)
            {
                Console.WriteLine("ArrayList is {0}", l);
            }

            #endregion

            #region Methods
            Program P= new Program();
            P.EvenNumbers();
            EvenMain(50);
            //EvenNumbers();
            InterviewPrep_2.Program.Print();
            #endregion

            Console.ReadKey();
        }

        #region Methods
        public void EvenNumbers()
        {
            int start = 0;
            while (start <= 20)
            {
                Console.WriteLine("Without static: "+start);
                start = start+2;
            }
        }

        public static void EvenMain(int a) 
        { 
            if (a % 2 == 0)
            {
                Console.WriteLine("Even Num with static member");
            }
            else
            {
                Console.WriteLine("Odd Num");
            }
        }
        #endregion


    }


}
