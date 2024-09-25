

namespace week_5_project
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            int total;


            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");
            Console.WriteLine("Welcome to sports calculator\n");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");

            



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter in your amount of goals scored: ");
                int goals = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your amount of assists");
                int assists= Convert.ToInt32(Console.ReadLine());


                total = goals + assists;

                Console.WriteLine("Your total points in your game are {0}", total);


            }
            Console.WriteLine("thanks for using my sports calculator");
            Console.ReadLine();





        }
    }
}
