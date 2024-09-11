namespace week_3_cw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double subTotal;
            double tax;
            double grandTotal;
            double GrandTax;
            double o, t, i;
            tax = .06;

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Welcome to subtotal and tax bill calculator!");
            Console.WriteLine("--------------------------------------------");

            Console.WriteLine("Enter in total for oil change: ");
            o = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in tire total: ");
            t = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Enter total for inspection: ");
            i = Convert.ToDouble(Console.ReadLine());

            subTotal = o + t + i;
            Console.WriteLine("Your subtotal is: {0}{1}", subTotal.ToString("C"), "!");

            GrandTax = subTotal * tax;

            Console.WriteLine("Your tax amount is: {0}{1}", GrandTax.ToString("C"), "!");

            grandTotal = subTotal + GrandTax;
            Console.WriteLine("Your grandTotal is: {0}{1}",grandTotal.ToString("C"), "!");

            Console.ReadKey();




            //day 3 
            double a, b, c;
            double total;

            string inputString;

            Console.WriteLine("Enter your name: ");

            inputString = Console.ReadLine();

            Console.WriteLine("Enter your first number");
            inputString = Console.ReadLine();
            a = Convert.ToDouble(inputString);


            Console.WriteLine("Enter in second number");
            inputString = Console.ReadLine();
            b = Convert.ToDouble(inputString);


            Console.WriteLine("enter in third number ");
            c = Convert.ToDouble(Console.ReadLine());


            total = (a + b + c) / 3;
            Console.WriteLine();
            Console.WriteLine("There average is : {0}{1}", total.ToString("C"), "!");
            //{0}=placeholder

            Console.ReadKey();






        }


    }
}
