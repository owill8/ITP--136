

namespace week_5_project
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
            int total_1;
            int total_2;
            int goals = 0;
            int assists = 0;
            


            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");
            Console.WriteLine("Welcome to sports calculator\n");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");

            Console.WriteLine("Enter in the amount of games you want to caclulate: ");
            int counter = Convert.ToInt32(Console.ReadLine());



            for (int i = 0; i < counter; i++)
            {


               
                
                
                Console.WriteLine("Enter in your amount of goals scored: ");
                 goals = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your amount of assists");
                 assists= Convert.ToInt32(Console.ReadLine());


               


            }



            total_1 = (goals + assists) * counter;
            total_2 = goals + assists;
            double average = total_2 / counter;


            Console.WriteLine("Your total points = {0}",  total_1 + " Points\n ");
            Console.WriteLine("Your average points per game = {0}\n", average);
            Console.WriteLine("Thanks for using my sports calculator!!\n");
            Console.WriteLine("\t\t PRESS ENTER TO CLOSE!");
           
            Console.ReadLine();





        }
    }
}
