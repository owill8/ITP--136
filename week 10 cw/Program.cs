namespace week_10_cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //classes objects 
           
            Employee emp1 = new Employee(); // objects 
            Employee emp2 = new Employee();

            emp1.EmployeeId = 1234;
            emp1.Lastname = "Williams";
            emp1.Firstname = "Owen";

            emp2.EmployeeId = 4567;
            emp2.Lastname = "Charles";
            emp2.Firstname = "jack";


            Console.WriteLine("{0,10}{1,20}{2,20}", "EmployeeId", "Lastname", "Firstname");

            Console.WriteLine("{0,10}{1,20}{2,20}", emp1.EmployeeId, emp1.Lastname, emp1.Firstname);

            Console.WriteLine("{0,10}{1,20}{2,20}", emp2.EmployeeId, emp2.Lastname, emp2.Firstname);

            emp1.Lastname = "Sieth";//update object

            Console.WriteLine("{0,10}{1,20}{2,20}", emp1.EmployeeId, emp1.Lastname, emp1.Firstname);

            Console.WriteLine("Enter in Employee ID: ");
            emp2.EmployeeId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Employee Last name: ");
            emp2.Lastname = Console.ReadLine();

            Console.WriteLine("Enter in Employee First name: ");
            emp2.Firstname = Console.ReadLine();

            Console.WriteLine("{0,10}{1,20}{2,20}", emp2.EmployeeId, emp2.Lastname, emp2.Firstname);


        }
        
    }
}
