using System;
using System.Linq;
using static System.Console;
namespace week_9_cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = { "Stephens", "Owen", "Tisky" };

            double[] quiz = new double[3]; // elements for the array loop will stop at 3;
            double[] test = new double[3];
            double[] assignments = new double[3];

            for (int i = 0; i < names.Length; i++)
            {
                WriteLine("Please enter the quiz average for {0}", names[i]);
                quiz[i] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the test average for {0}", names[i]);
                test[i] = Convert.ToDouble(ReadLine());

                WriteLine("Please enter the assignment average for {0}", names[i]);
                assignments[i] = Convert.ToDouble(ReadLine());
            }
            WriteLine("{0,10}{1,20}{2,10}{3,10}", "Name", "quiz", "Test", "assignments");
            for (int x = 0; x < quiz.Length; x++)
            {

                WriteLine("{0,10}{1,20}{1,10}{2,10}", names[x], quiz[x],test[x], assignments[x]);
            }
            int e = 0;

            foreach (var name in names)
            {

                double average;

                average = (quiz[e] + test[e] + assignments[e]) / 3;

                WriteLine("{0,15}{1,15}", name, average.ToString("F2"));
                e++;
            }
            for (int x = 0; x < quiz.Length; x++)
            {
                double average2;

                average2 = (quiz[x] + test[x] + assignments[x]) / 3;

                WriteLine("average is: " + average2.ToString("F2"));
            }
            

        }
    }
}
