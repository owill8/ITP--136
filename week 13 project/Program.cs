using System.Runtime.CompilerServices;

namespace week_13_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();//students object
            List<Teacher> teachers = new List<Teacher>();//list of class teachers object

            

            foreach (Student student in students)
            {
                Console.WriteLine(student.IdNum + " " + student.fullName + " " + student.address + " " + student.Major + " " + student.Advisor);
            }

            Console.WriteLine("Welcome to my Inheritance and Polymorphism program!");

            Console.WriteLine();

            Console.WriteLine("Enter in the number of students: ");
            int NumOfStudents = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine("ENter in the number of teachers: ");
            int NumOfTeacher = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < NumOfStudents; i++)
            {

                Console.WriteLine("Enter in your id: ");
                int Empnum= Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter in your Address: ");
                string Address = Console.ReadLine();
                
                Console.WriteLine("Enter in your major: ");
                string Major = Console.ReadLine();

                Console.WriteLine("Enter in your advisor: ");
                string Advisor = Console.ReadLine();

                students.Add(new Student(Empnum,name,Address,Major,Advisor));
            }

            for (int i = 0; i < NumOfTeacher; i++)
            {
                Console.WriteLine("Enter in your id: ");
                int Empnum2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your name: ");
                string name2 = Console.ReadLine();

                Console.WriteLine("Enter in your Address: ");
                string Address2 = Console.ReadLine();

                Console.WriteLine("Enter in your Salary: ");
                double Salary2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter in your years of service");
                string Years = Console.ReadLine();

                teachers.Add(new Teacher(Empnum2, name2, Address2, Salary2, Years));

            }

            

            Console.WriteLine("{0,10}{1,20}{2,10}{3,10}{4,10}", "Id", "name", "Address", "Major", "Advisor");
            

            foreach (Student student in students)
            {
                Console.WriteLine("{0,10}{1,20}{2,10}{3,10}{4,10}", student.IdNum, student.fullName, student.address, student.Major, student.Advisor);
            }

            Console.WriteLine();

            Console.WriteLine("{0,10}{1,20}{2,10}{3,10}{4,10}", "Id", "name", "Address", "Salary", "Years");

            foreach(Teacher teacher in teachers)
            {
                Console.WriteLine("{0,10}{1,20}{2,10}{3,10}{4,10}", teacher.IdNum, teacher.fullName, teacher.address, teacher.Salary, teacher.Year_Of_Service);
            }

        }
    }
}
