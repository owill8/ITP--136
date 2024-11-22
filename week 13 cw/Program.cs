namespace week_13_cw
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //inheritance and polymorphism

            //object creation//
            List<Salary> salList = new List<Salary>();//list of class
            List<Commission> comlist = new List<Commission>();

            salList.Add(new Salary(1313, "Owen WIlliams", 50000));
            salList.Add(new Salary(4352, "Tisky Williams", 500000000));

            comlist.Add(new Commission(4353, "Bill gate", 80000000));
            comlist.Add(new Commission(2144, "Owen TIsky", 500));

            foreach (Commission co in comlist)
            {
                Console.WriteLine(co.EmployeeNum + " " + co.FullName + " " + co.Sales);
            }

            foreach(Salary sal in salList)
            {
                Console.WriteLine(sal.EmployeeNum + " " + sal.FullName + " " + sal.SalaryAmount);
            }

            Console.WriteLine("How many employees do you wannt to add?: ");
            int inputAnswer = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < inputAnswer; i++)
            {
                Console.WriteLine("Enter in employee number");
                int empNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in employee FullName: ");
                string fn = Console.ReadLine();

                Console.WriteLine("Enter in your salary: ");
                double salary = Convert.ToDouble(Console.ReadLine());   

                salList.Add(new Salary(empNum, fn, salary));
            }

            Console.ReadKey();
        }
    }
}
