using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace week_7_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name, Address, Date_of_travel;
            
            Console.WriteLine("*****************************");
            Console.WriteLine("Welcome to Reynolds Airline!!");
            Console.WriteLine("*****************************\n");


            Console.WriteLine("Enter in your name: ");
            Name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter in your Address: ");
            Address = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Enter in your date of travel:  MONTH/DATE/YEAR : ");
            Date_of_travel = Console.ReadLine();
            Console.WriteLine();

            int collectseats;
            collectseats = collectSeats(1, 0, 30);//call

            Console.WriteLine("Your total price is: {0}", collectseats.ToString("C"));
            
            Console.WriteLine();
            
            int collect_Bags;

            collect_Bags = collectBags(25, 0);//call

            Console.WriteLine("Your total for bags: {0}", collect_Bags.ToString("C"));
           
            Console.WriteLine();

            double tip = .05;

            double TaxAmount = (collect_Bags + collectseats) * tip;//calculate the tip amount 
            double SubTotal = (collect_Bags) + (collectseats);//total before tax added 
            double GrandTotal = SubTotal + TaxAmount;//total after tax gets added


            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("#############################");
            Console.WriteLine("          Receipt            ");
            Console.WriteLine("#############################\n");
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine(".*.*.*.*.*.*.*.*.*.*");
            Console.WriteLine("SubTotal is: {0}", SubTotal.ToString("C"));
            Console.WriteLine("Tax amount: {0}", TaxAmount.ToString("C"));
            Console.WriteLine("Grand Total amount: {0}", GrandTotal.ToString("C"));
            Console.WriteLine(".*.*.*.*.*.*.*.*.*.*\n");

            Console.WriteLine("Name: {0}\n", Name);
            Console.WriteLine("Address: {0}\n ", Address);
            Console.WriteLine("Date of travel: {0} ", Date_of_travel);

            Console.WriteLine();

            Console.WriteLine("Thanks for using Reynolds Airline!");

            Console.WriteLine();

            Console.WriteLine("[PRESS ENTER TO CLOSE]");

            Console.ReadKey();

        }
        static int collectBags(int bag, int total)
        {

            string option;

            Console.WriteLine("Do you want to check bags? ");
            option = Console.ReadLine();

            if (option == "Y" || option == "y")
            {

                Console.WriteLine("How many bags?");

                int bags_1 = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= bags_1; i++)
                {

                    Console.WriteLine("How many bags? 25$ each");

                    int bags = Convert.ToInt32(Console.ReadLine());

                    total += bags * bag;
                }

                return total;
            }

            else
            {
                Console.WriteLine("Ok thanks for visiting! ");
                return 0;//will return $0.00 to main
            }

        }

        static int collectSeats(int i, int total, int seat)
        {
            string option;

            Console.WriteLine("Do you want to pay for seats Y/N ? ");
            option = Console.ReadLine();

            Console.WriteLine();

            if (option == "Y" || option == "y")
            {

                Console.WriteLine("How many times do you want to purchase seats");
                int seats = Convert.ToInt32(Console.ReadLine());
                while (i <= seats)
                {

                    Console.WriteLine("How many seats? 30$ each seat");
                    int seats2 = Convert.ToInt32(Console.ReadLine());
                    total += seats2 * seat;
                    i++;

                }
                return total;
            }

            else//option N or n
            {
                Console.WriteLine("You did not buy any seats");
                return 0;
            }

        }
    }
}

