namespace week_11_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator program");

            Console.WriteLine();

            decimal a, b, result;
            int option;

           
            
                Console.WriteLine("\nEnter in number 1: ");
                a = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Enter in number 2: ");
                b = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Choose one of the following");
                Console.WriteLine("1.Add");
                Console.WriteLine("2.Multiply");
                Console.WriteLine("3.Subtraction");
                Console.WriteLine("4.Division");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    try
                    {
                        result = a + b;
                        Console.WriteLine("Your result is: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Exception" + ex);
                    }

                }
                else if (option == 2)
                {

                    try
                    {
                        result = a * b;
                        Console.WriteLine("Your result is: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR CAUGHT");
                    }
                }
                else if (option == 3)
                {

                    try
                    {
                        result = a - b;
                        Console.WriteLine("Your result is: " + result);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ERROR CAUGHT" + ex);
                    }
                }
                else if (option == 4)
                {

                    try
                    {
                        result = a / b;
                        Console.WriteLine("Your result is: " + result);
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("()((_()_(())*ERROR CAUGHT*)(*&()*)*(&)" + ex);
                    }
                }
                else
                {
                    Console.WriteLine("Enter in a number 1-4 please");
                }

                Console.ReadKey();
            

        }
    }
}
