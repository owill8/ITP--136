using static System.Console;
namespace week_4

{
    internal class Program
    {
        static void Main(string[] args)
        {
            int first = 5;
            int second = 6;

            if (first == second)
            {
                WriteLine("The numbers are equal");
                
            }
            else
            {
                WriteLine("The numbers are not equal");
                if (first > second)
                {
                    WriteLine("First number is greater than second");
                }
                else
                {
                    WriteLine("Second is greater than first");
                }
            }

            char ch = 'x';
            if (ch == 'a' || ch == 'A')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'e' || ch == 'E')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'i' || ch == 'I')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'o' || ch == 'O')
            {
                WriteLine("Vowel");
            }
            else if (ch == 'u' || ch == 'U')
            {
                WriteLine("Vowel");
            }
            else
            {
                WriteLine("Constant");
            }


            int option, a, b, total;
            WriteLine("Enter in first number");
            a = Convert.ToInt32(Console.ReadLine());

            WriteLine("Enter in your second number");
            b= Convert.ToInt32(Console.ReadLine());

            WriteLine("1- Add, 2-subtract, 3- multiply, 4-divide");
            option = Convert.ToInt32(Console.ReadLine());


            switch (option)
            {
                case 1:
                    total = a + b;
                    WriteLine("the numbers added are {0},", total);
                    break;
                case 2:
                    total = a - b;
                    WriteLine("the numbersubtracted are {0},", total);
                    break;
                case 3:
                    total = a * b;
                    WriteLine("The numbers times are {0}", total);
                    break;
                case 4:
                    total = a / b;
                    WriteLine("The numbers divided are {0}", total);
                    break;

                default:
                    WriteLine("Enter in bad number");
                    break;
            }


        
        
        
        
        
        
        
        }
    }
}
