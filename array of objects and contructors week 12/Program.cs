namespace array_of_objects_and_contructors_week_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array of Objects and contructors");

            Employee emp1 = new Employee(1313, 2525.99, "Stephens", "Owen", "Teacher");//constructor call

            Console.WriteLine(emp1.EmployeeNumber + " " + emp1.Salary + " " + emp1.LastName + " " + emp1.FirstName + " " + emp1.Position);//contructor output

            int numEmp;

            Console.WriteLine("How many employees do you want to enter");
            numEmp = Convert.ToInt32(Console.ReadLine());

            Employee[] empArray = new Employee[numEmp];

            for (int x = 0; x < empArray.Length; x++)//loop to collect data
            {
                populateEmployee(ref empArray[x]);
            }

            static void populateEmployee(ref Employee e)//catching the reference (e) memory in the cpu menu method by ref
            {
                Console.WriteLine("Enter empolyee number");
                int empNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the salary");
                double a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter in last name?");
                string lastname = Console.ReadLine();

                Console.WriteLine("Enter in first name");
                string firstname = Console.ReadLine();

                Console.WriteLine("Enter the position");
                string posit = Console.ReadLine();

                e = new Employee(empNum, a, lastname, firstname, posit);//reference object to the ref array


            }

            for (int y = 0; y < empArray.Length; y++)
            {
                Console.WriteLine(empArray[y].EmployeeNumber + " " + empArray[y].Salary + " " + empArray[y].LastName + " " + empArray[y].FirstName + " " + empArray[y].Position);
            }

            Console.WriteLine("Enter the number belolw that you would like to modify");

            for (int z= 0; z < empArray.Length; z++)
            {

                Console.WriteLine(z + 1 + " "+empArray[z].EmployeeNumber + " " + empArray[z].LastName + " " + empArray[z].FirstName);//shows the menu of all properties
            }

            int selectedEmployee = Convert.ToInt32(Console.ReadLine());

            modifyEmpolyee(ref empArray[selectedEmployee - 1]);

            static void modifyEmpolyee(ref Employee e)
            {
                Console.WriteLine("Enter what you would like to update \n1.Employee number \n 2.Salary \n 3.Last Name \n 4.First Name \n 5.Position");


                int userInput = Convert.ToInt32(Console.ReadLine());


                if (userInput == 1)
                {
                    Console.WriteLine("What is the new number ?");
                    int newNum = Convert.ToInt32(Console.ReadLine());
                    e.EmployeeNumber = newNum;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("what is new salary");
                    double newSalary = Convert.ToDouble(Console.ReadLine());
                    e.Salary = newSalary;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("What is new Last name?");
                    string newLname = Console.ReadLine();
                    e.LastName = newLname;

                }
                else if (userInput == 4)
                {
                    Console.WriteLine("What is new FIrstname?");
                    string newFName = Console.ReadLine();
                    e.FirstName = newFName;
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("What is new position?");
                    string newPosit = Console.ReadLine();
                    e.Position = newPosit;
                }
                else
                {
                    Console.WriteLine("Enter in 1-5 please");
                }




            }

            for (int y = 0; y < empArray.Length; y++)
            {
                Console.WriteLine(empArray[y].EmployeeNumber + " " + empArray[y].Salary + " " + empArray[y].LastName + " " + empArray[y].FirstName + " " + empArray[y].Position);
            }


        }
    }
}
