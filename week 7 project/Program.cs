using System;
using System.Numerics;
using System.Runtime.InteropServices;

namespace week_7_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Name;
            string Address;
            string Date_of_travel;


            Console.WriteLine("*****************************");
            Console.WriteLine("Welcome to Reynolds Airline!!");
            Console.WriteLine("*****************************\n");

            Console.WriteLine("Enter in your name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter in your Address: ");
            Address = Console.ReadLine();

            Console.WriteLine("Enter in your date of travel:  MONTH/DATE/YEAR : ");
            Date_of_travel = Console.ReadLine();

           

            
            


                int collectseats;
                collectseats = collectSeats();//call

                Console.WriteLine("Your total price is: {0}", collectseats.ToString("C"));

                
            
                



                Console.WriteLine("Enter in how many bags: ");
                int count = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 0; i < count; i++)
                {

                    int collect_Bags;

                    collect_Bags = collectBags();//call


                    Console.WriteLine("Your total price for bags is {0} \n", collect_Bags.ToString("C"));

                    

                    double tip = .05;
                
                    double GrandTax = (collect_Bags + collectseats) * tip;//calculate the tip amount 
                    double SubTotal = (collect_Bags) + (collectseats);//total before tax added 
                    double GrandTotal = SubTotal + GrandTax;//total after tax gets added
                    
                     Console.ForegroundColor = ConsoleColor.Green;
                     Console.WriteLine("#############################");
                     Console.WriteLine("          Receipt            ");
                     Console.WriteLine("#############################");
                     Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*");
                    Console.WriteLine("Total is: {0}", SubTotal.ToString("C"));
                    Console.WriteLine("Tax amount: {0}", GrandTax.ToString("C"));
                    Console.WriteLine("Grand Total amount: {0}", GrandTotal.ToString("C"));
                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*");

                
                }

            
            

            

            

            


           
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Name: {0}\n", Name);
            Console.WriteLine("Address: {0}\n ", Address);
            Console.WriteLine("Date of travel: {0} ", Date_of_travel);

            Console.ReadKey();



        }
        static int collectBags()
        {
            int bag = 25;
            string option;
            

            
                Console.WriteLine("Do you want to check bags? ");
                option = Console.ReadLine();

                if (option == "Y" || option == "y")
                {
                    
                    
                        Console.WriteLine("How many bags?");
                        int bags = Convert.ToInt32(Console.ReadLine());

                int total = bags * bag;
                return total;

                }
                
                
                else
                {
                    Console.WriteLine("Ok thanks for visiting! ");
                    return 0;
                }


            

        }



            static int collectSeats()
            {
                string option;
                int seat = 30;


                Console.WriteLine("Do you want to pay for seats Y/N ? ");
                option = Console.ReadLine();

                if (option == "Y" || option == "y")
                {

                    Console.WriteLine("Enter in your amount of seats ");
                    int seats = Convert.ToInt32(Console.ReadLine());

                    int total2 = seat * seats;
                    return total2;
                }
                else
                {
                    Console.WriteLine("You did not buy any seats");
                    return 0;
                }
            }



        }
    }

