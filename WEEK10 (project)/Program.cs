using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK10__project_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //objects
           Food f1 = new Food();
           Food f2 = new Food();


            f1.FoodID = 49675;
            f1.Name = "Apple";
            f1.Description = "Red";
            f1.Cost = 2;


            f2.FoodID = 29045;
            f2.Name = "HamBurger";
            f2.Description = "Hamburger with a bun and cheese!";
            f2.Cost = 12;

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", " FoodID ", "Name ", " Description", " Cost");

            Console.WriteLine("{0,10}{1,20}{2,20}{3,20}", f1.FoodID,f1.Name,f1.Description,f1.Cost + "$");



        }
    }
}
