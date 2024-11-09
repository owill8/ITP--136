using System;

namespace classes_project_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to objects program");

            Console.WriteLine();
            string[] Foodid = new string[100];

            Food f1 = new Food(4958,"fortnite","REd",4);//constructor
            Food f2 = new Food(5655,"Apple","Red",20);


            Console.WriteLine(f2.TooMuch());

            Console.WriteLine("Enter in your food ID: ");
            f1.FoodId = Convert.ToInt32(Console.ReadLine());

            


            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", "FoodId", "Name", "Description", "Cost");

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", f1.FoodId, f1.Name, f1.Description, f1.Cost + "$");

            Console.WriteLine();

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", "FoodId", "Name", "Description", "Cost");

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", f2.FoodId, f2.Name,f2.Description, f2.Cost + "$");


        }
    }
}
