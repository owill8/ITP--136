namespace CW_week_6
{
    internal class Program
    {
        static void Main(string[] args)//this is a method 
        {
            //methods!!,Console.WriteLine() is a method itself;
            //calling method 

            int a, b;

            WelcomeMessage();
            for (int i = 0; i < 3; i++)//3 problems for adding because of for loop
            {
                a = askNumber();
                b = askNumber();

                addNumber(a, b);
            }
            Console.WriteLine("This ends the program");

            Console.ReadLine();

           
        }
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my calculator"); 

            Console.ReadKey();
        }
        static int askNumber()//return method 
        {
            int x;
            Console.WriteLine("Please enter in a number");
            x = Convert.ToInt32(Console.ReadLine());

            return x;
        }

        static void addNumber(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("Your total is {0}", total);

           
        }
        static int addNumber2(int num1, int num2)
        {
            int total = num1 + num2;

            return total;
        }

    
    
    
    
    
    
    }
}
