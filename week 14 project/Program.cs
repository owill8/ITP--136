using System;
using System.Runtime.InteropServices.Marshalling;

namespace Week14_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Cake Order shop");

            List<CakeOrders> cakeOrders = new List<CakeOrders>();

            int counter = 0;

            char Continue = 'y';

            while(Continue == 'y' || Continue == 'Y')
            {
                CollectCakeOrders(ref cakeOrders);

                Console.WriteLine("Would you like to continue y/n");
                Continue = Convert.ToChar(Console.ReadLine());
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
