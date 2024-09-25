namespace week_5_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            a = 0;
            b = 5;

            // //while (a < b)
            // {
            //     Console.WriteLine(a);


            //     a++;
            //// }
            ///

            //1st part inistial value 
            //2nd part is the condition statment 
            //3rd part is the incrementer

            //variables 
            int total;

            Console.WriteLine("Welcome to my calculator");
            
            
            
            
            
            
            for (int k = 0; k < 3; k++)

            {
                Console.WriteLine("Enter in your first number");
                a = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter in your second number");
                b = Convert.ToInt32(Console.ReadLine());

                total = a + b;

                Console.WriteLine("your total is: " + total);
            }
            Console.WriteLine("Thank you for using the calculator");
            Console.ReadLine();
        }
    }
}
