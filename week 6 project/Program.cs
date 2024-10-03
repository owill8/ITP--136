namespace week_6_project
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("How many method examples do you want?");
            int count = Convert.ToInt32(Console.ReadLine());
            
            
            
            
            
            for (int i = 0; i < count; i++)
            {
                WelcomeStatement();
                int secretNumber = 8;
                MagicNumber(secretNumber);
                int L, W;
                Console.WriteLine("Enter in your length: ");
                L = Convert.ToInt32(Console.ReadLine());


                Console.WriteLine("Enter in your width: ");
                W = Convert.ToInt32(Console.ReadLine());

                FindArea(L, W);

                double taxRate = LocalTaxRate();//taxRate variable


                Console.WriteLine("Your tax rate is " + taxRate);
            }
        }
        static void WelcomeStatement()
        {
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");
            Console.WriteLine("   Welcome to My Method Examples    \n");
            Console.WriteLine("*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*.*\n");
        }
        static void MagicNumber(int secretNumber)
        {
            Console.WriteLine("Your Magic Number is " + secretNumber);
        }
        static void FindArea(int L, int W)
        {
           

            double result = L * W;

            Console.WriteLine("Your area is " + result);

            Console.WriteLine("\tPRESS ENTER");

            Console.ReadKey();
        }

        static double LocalTaxRate()
        {
            Console.WriteLine("Please enter your tax rate");
            double taxRate = Convert.ToDouble(Console.ReadLine());

            return taxRate;
        }

       


    }
}
