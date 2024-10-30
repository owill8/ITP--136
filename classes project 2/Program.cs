using System;

namespace classes_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to objects program");

            Console.WriteLine();


            Food f1 = new Food();
            Food f2 = new Food();

            f1.FoodId = 49675;
            f1.Name = "Apple";
            f1.Description = "Red";
            f1.Cost = 2;

            f2.FoodId = 5858;
            f2.Name = "  Cheese Burger";
            f2.Description = "Bun,Patty";

      
            f2.Cost = 20;



            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", "FoodId", "Name", "Description", "Cost");

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", f1.FoodId, f1.Name, f1.Description, f1.Cost + "$");

            Console.WriteLine();

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", "FoodId", "Name", "Description", "Cost");

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", f2.FoodId, f2.Name,f2.Description, f2.Cost + "$");


        }
    }
}
