using System.Diagnostics;
using System.Runtime.InteropServices;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            number = showNumber(9);
            number = showNumber(10, 9);

            Console.WriteLine(number);
            Console.WriteLine(number);
        }

        static int showNumber(int a)
        {
            Console.WriteLine("Your number is " + a);
            return a;
        }
        static int showNumber(int a, int b)
        {
            Console.WriteLine(a + " " + b);
            return a;
            
        }
    }
}
