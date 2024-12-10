using System;
using System.Runtime.InteropServices.Marshalling;

namespace Week14_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cake Order shop \nOptions will be decoration and designs for cakes");


            Console.WriteLine();

            List<CakeOrders> cakeOrders = new List<CakeOrders>();

            int counter = 0;

            char Continue = 'y';

            while(Continue == 'y')
            {
                CollectCakeOrders(ref cakeOrders);
                counter++;

                Console.WriteLine("Would you like to continue y/n");
                Continue = Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Decoration", "Design");

            foreach(CakeOrders cakeOrder in cakeOrders)
            {
                Console.WriteLine("{0,-15}{1,-20}{2,-20}", cakeOrder.CakeName, cakeOrder.CakeDecoration, cakeOrder.CakeDescription);
            }


            static void CollectCakeOrders(ref List<CakeOrders> co)
            {
                var ListOfDecoration = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();
                var ListOfDesigns = File.ReadLines("Design.csv").Select(line => new Design(line)).ToList();

                Console.WriteLine("Name this order: ");
                string name = Console.ReadLine();

                Console.WriteLine("Which decoration would you like?");

                foreach (Decorations d in ListOfDecoration)
                {
                    Console.WriteLine($"{d.DecorationId}\t{d.DecorationName}");
                }

                int c = Convert.ToInt32(Console.ReadLine());
                string Decoration = ListOfDecoration[c - 1].DecorationName;

                Console.WriteLine("Which Deisgn do you want?");

                foreach (Design d in ListOfDesigns)
                {
                     Console.WriteLine($"{d.DesignId}\t{d.DesignName}");
                }

                int b = Convert.ToInt32(Console.ReadLine());
                string Design = ListOfDesigns[b - 1].DesignName;

                co.Add(new CakeOrders(name, Decoration, Design));
            }
            

               //contructor for decorations & Design cake 
               //CakeOrder class for object cake order name, cake order Decoration and cake order design
        }
    }
}
