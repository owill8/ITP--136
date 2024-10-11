using System.Numerics;

namespace project_7_with__bonus_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************");
            Console.WriteLine("****Welcome to Reynolds Airline!!****");
            Console.WriteLine("*************************************\n");


            Console.WriteLine("Enter in name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter in your Address");
            string Address = Console.ReadLine();

            Console.WriteLine("Enter in your Date of travel: MONTH,DATE,YEAR");
            string Date_of_travel = Console.ReadLine();
            Console.WriteLine();


            Console.WriteLine("Your name: " + name);
            Console.WriteLine("Your Address: " + Address);
            Console.WriteLine("Your date of travel: " + Date_of_travel + "\n");


            BagData(25);
            CollectSeats(30,0);

            
}

        static void BagData(int bag)
        {
            string option;
            

            Console.WriteLine("Do you want to check bags? Y/N");
            option = Console.ReadLine();

            if (option == "Y" || option == "y")
            {
                Console.WriteLine();
                Console.WriteLine("Enter in number of bags");
                int bags = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                for (int i = 0; i <= bags; i++)
                {
                    double tax = .05;
                    double subTotal = bag * bags;
                    double TaxAmount = subTotal * tax;
                    double GrandTotal = subTotal + TaxAmount;
                    int total = bag * bags;
                    
                   
                    Console.WriteLine("Total price of bags is: {0}",total.ToString("C"));
                    Console.WriteLine("Here is your receipt");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("#############################");
                    Console.WriteLine("          Receipt            ");
                    Console.WriteLine("#############################\n");
                    Console.ForegroundColor = ConsoleColor.White;

                   

                    
                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*");
                    Console.WriteLine("SubTotal is: {0}", subTotal.ToString("C"));
                    Console.WriteLine("Tax amount: {0}", TaxAmount.ToString("C"));
                    Console.WriteLine("Grand Total amount: {0}", GrandTotal.ToString("C"));
                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*\n");

                    
                }
               

            }
            else
            {
                int total = 0;
                Console.WriteLine("You Choose not to by any bags");
                Console.WriteLine("Your total is {0}", total.ToString("C"));
                Console.WriteLine();
                
            }
            
        }

        static void CollectSeats(int seat,int i)
        {
            string option;
            


            Console.WriteLine("Do you want to pay for seats? Y/N  ");
            option = Console.ReadLine();
            Console.WriteLine();

            if (option == "Y" || option == "y")
            {
                Console.WriteLine("Enter in number of seats");
                int seats = Convert.ToInt32(Console.ReadLine());

                while (i <= seats)
                {

                    double tax = .05;
                    double SubTotal = seats * seat;
                    double TaxAmount = SubTotal * tax;
                    double GrandTotal = SubTotal + TaxAmount;
                    int total = seats * seat;
                    

                    Console.WriteLine("Total for seats is {0}", total.ToString("C"));
                    Console.WriteLine("Here is your receipt");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("#############################");
                    Console.WriteLine("          Receipt            ");
                    Console.WriteLine("#############################\n");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*");
                    Console.WriteLine("SubTotal is: {0}", SubTotal.ToString("C"));
                    Console.WriteLine("Tax amount: {0}", TaxAmount.ToString("C"));
                    Console.WriteLine("Grand Total amount: {0}", GrandTotal.ToString("C"));
                    Console.WriteLine(".*.*.*.*.*.*.*.*.*.*\n");
                    i++;
                }
            
            }
            else
            {
                int seats = 0;
                Console.WriteLine("You did not pay for any seats");
                Console.WriteLine("Total for seats is {0}", seats.ToString("C"));
            }

            Console.WriteLine("'ENTER TO CLOSE'");
            Console.ReadKey();
        }
        
        
    }
}
