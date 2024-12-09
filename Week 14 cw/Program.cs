using System;
using System.Security.Cryptography.X509Certificates;

namespace Week14cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ice cream shop");
            

            char moreItems = 'y';

            int counter = 0;

            List<Orders> orders = new List<Orders>();

            while (moreItems == 'y')
            {
                Console.WriteLine("Lets get the items for item {0}", counter + 1);//format the loop

                collectOrder(ref orders);
                counter++;

                Console.WriteLine("would you like to continue? y/n");
                moreItems = Convert.ToChar(Console.ReadLine());

                int choice;

                Console.WriteLine("Would you like to add text to: \n 1.Flavor \n 2.Toppings");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    string path = @"C:\Users\owenc\Downloads";
                    StreamWriter sw = File.AppendText(path);// object creation from StreamWriter class
                    
                }

               
            }

            Console.WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Flavor", "topping");

            foreach (Orders o in orders)
            {
                Console.WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderFlavor, o.OrderTopping);
            }
            Console.ReadKey();

         
        }
        public static void collectOrder(ref List<Orders> o)
        {
            var listOfFlavors = File.ReadLines("Flavors.csv").Select(line => new Flavors(line)).ToList();
            var listOfToppings = File.ReadLines("Toppings.csv").Select(line => new Toppings(line)).ToList();

            Console.WriteLine("Name this order");
            string name = Console.ReadLine();

            Console.WriteLine("Which flavor would you like?");
            foreach (Flavors f in listOfFlavors)//display Flavor.csv file flavors
            {
                Console.WriteLine($"{f.FlavorID}\t{f.FlavorName}");
            }

            int a = Convert.ToInt32(Console.ReadLine());
            string flavor = listOfFlavors[a - 1].FlavorName;

            Console.WriteLine("Which topping would you like?:");

            foreach(Toppings t in listOfToppings)
            {
                Console.WriteLine($"{t.ToppingID}\t{t.ToppingName}");
            }

            int b = Convert.ToInt32(Console.ReadLine());
            string topping = listOfToppings[b - 1].ToppingName;

            o.Add(new Orders(name, flavor, topping));
        }
    }
}
