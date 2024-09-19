namespace week_4_project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Welcome to doctor visit calculator");
            Console.WriteLine("----------------------------------");

            Console.WriteLine("Enter in 1-Doctor Sick Apointment or 2-Doctor check up");
           int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:

                    int base_visit_child1 = 50;
                    int adult1 = 75;
                    int total, total2;

                    Console.WriteLine("are you a child-1 or a adult-2");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1 || choice == 2)
                    {
                        Console.WriteLine("Child price is: {0}", base_visit_child1.ToString("C"));
                        Console.WriteLine("Adult price is: {0}", adult1.ToString("C"));
                    }
                    else {
                        Console.WriteLine("Enter in 1 or 2 please");
                    }
                    Console.WriteLine("Did you have labs done? Y/N");
                    char response = Convert.ToChar(Console.ReadLine());

                    if (response == 'Y' || response == 'y')
                    {
                        total = base_visit_child1 + 25;
                        total2 = adult1 + 25;
                        Console.WriteLine("Your total price for a Adult is: {0}",total2.ToString("C"));
                        Console.WriteLine("Your total price for a Child is: {0}",total.ToString("C"));
                    }
                    else
                    {
                        Console.WriteLine("Your total price for a Adult is: {0}", adult1.ToString("C"));
                        Console.WriteLine("Your total price for a Child is: {0}", base_visit_child1.ToString("C"));
                    }
                    break;
                case 2:
                    int base_visit_child = 75;
                    int adult = 100;
                    Console.WriteLine("Are you a child-1 or a adult-2");
                    int choice2 = Convert.ToInt32(Console.ReadLine());

                    if (choice2 == 1)
                    {
                        Console.WriteLine("Your total price for a child is: {0}", base_visit_child.ToString("C"));
                    }
                    else if (choice2 == 2)
                    {
                        Console.WriteLine("Your total price for a Adult is: {0}",adult.ToString("C"));
                    }
                    else
                    {
                        Console.WriteLine("Enter in 1 or 2 please");
                    }
                    break;
                       
                 
           
                            
                            
              }


            Console.ReadKey();
        
        }
    }
}
