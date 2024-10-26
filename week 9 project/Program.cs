namespace week_9_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] make = new string[5];
            string[] model = new string[5];
            double[] prices = new double[5];

            Console.WriteLine("Enter in information for [5] cars");

            Console.WriteLine();

            for (int i = 0; i < make.Length; i++)
            {
                Console.WriteLine("Enter in car " + (i + 1));

                Console.WriteLine();

                Console.WriteLine("Enter in make of car: ");
                make[i] = Console.ReadLine();

                Console.WriteLine("Enter in model of car: ");
                model[i] = Console.ReadLine();

                Console.WriteLine("Enter in price for car: ");
                prices[i] = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

            }

            Console.WriteLine("{0,10}{1,12}{2,15}", "Make", "Model", "Price$");

            for(int k = 0; k < make.Length; k++)
            {
                
                Console.WriteLine("{0,10}{1,12}{2,15}", make[k], model[k], prices[k]+"$");
            }

            Console.WriteLine();

            double MaxPrice = prices.Max();
            int p = Array.IndexOf(prices, MaxPrice);
            Console.WriteLine("The highest price is: " + prices[p]);
        }
    }
}
