using static System.Console;

namespace arrays_week_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ARRAYS week 9");

            WriteLine();

            string[] names = { "Stephens", "Owen", "Tisky", "Crosby", "C#" };

            //WriteLine(names[1]);

            for (int i = 0; i < names.Length; i++)
            {
                WriteLine(names[i]);
            }

            int[] nums = { 1, 2, 3, 4 };// int data type nums variable for array 
            
            double[] price = { 12.23, 24.24,74.24,23.43,43.43 };

            for (int i = 0; i < nums.Length; i++)
            {
                WriteLine(nums[i]);
            }

            for (int i = 0; i < price.Length; i++)
            {
                WriteLine(price[i]);
            }
            for (int i = 0; i < price.Length; i++)
            {
                WriteLine("{0,-10}{1,10}", names[i],price[i]);
            }

        }
    }
}
