namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ParentClass pp=new ParentClass();
            

            Console.WriteLine("-----------------------------");
            ChildClass cc = new ChildClass
            {
                Name = "Neelakandan"
            };
            
            Console.ReadKey();
        }
    }
}
