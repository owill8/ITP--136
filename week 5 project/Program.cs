

using System.Numerics;

namespace week_5_project
{
    internal class Program
    {
        static void Main(string[] args)
        {


           
           
            int goals = 0;
            int assists = 0;
            int total;
            


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

                total = goals + assists;

                Console.WriteLine("Your total points = {0}", total + " Points\n ");

            }



            


            
            Console.WriteLine("Thanks for using my sports calculator!!\n");
            Console.WriteLine("\t\t PRESS ENTER TO CLOSE!");
           
            Console.ReadLine();





        }
    }
}
