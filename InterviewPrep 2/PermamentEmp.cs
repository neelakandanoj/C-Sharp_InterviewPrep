namespace InterviewPrep_2
{
    public class PermamentEmp:Employee
    {
        public int ID=10;

        public int Emplcount()
        {
            ID = 1;
            Employee emp = new Employee();
            emp.TestData();
            return ID;
        }
    }
}