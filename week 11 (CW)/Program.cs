using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week_11__CW_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numberArray = { "Gretsky", "Jordan", "Ruth" };
            var num11 = 0;


            try
            {
                Console.WriteLine("Enter the element you want to see");
                int elementNumber = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(numberArray[elementNumber]);
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine("Please enter in the numbers 0-2");
            }

            
            
            
            











            //expection handling 
            int num1, num2;

            double total;

            Console.WriteLine("Please enter in a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter in 2 number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                total = num1 / num2;
                Console.WriteLine("Your result is: " + total);
            }
            catch(DivideByZeroException e)//e is the variable for the execption
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Exception caught: " + e);//outputing the variable to tell you what the error is
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadKey();
        }
    }
}
