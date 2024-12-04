using System.Xml.Serialization;

namespace Pokemon_game_Final_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("----------------------------------");
                Console.WriteLine("--Welcome to Pokemon Battle game--");
                Console.WriteLine("----------------------------------");

                Console.WriteLine();

                Console.WriteLine("You can go agianst a Grass type or Water type");

                Console.WriteLine();

                Console.WriteLine("Choose one of the following Pokemon");
                Console.WriteLine("1 - Fire type\n" + "2 - Water type\n" + "3 - Grass type\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Pokemon player = new FirePokemon("Charmander");
                    Pokemon enemy1 = new GrassPokemon("Bulbasaur");

                    Console.WriteLine("Player pokemon: " + player);
                    Console.WriteLine("Enemy pokemon: " + enemy1);

                    while(player.IsAlive() & enemy1.IsAlive())
                    {
                        Console.WriteLine("Enter in your attack");
                        Console.WriteLine("\nChoose your action: 1. Attack");
                        string action = Console.ReadLine();

                        if (action == "1")
                        {
                            Console.WriteLine("Player Turn Description");

                            Console.WriteLine();
                            // Player attacks
                            player.Attack(enemy1);

                            Console.WriteLine();

                            // Opponent attacks if still alive
                            if (enemy1.IsAlive())
                            {
                                Console.WriteLine("Enemy player turn Description");
                                enemy1.Attack(player);

                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid action! You lost your turn.");
                        }
                    }
                    //determine winner
                    if (player.IsAlive())
                    {
                        Console.WriteLine("CONGRATULATIONS YOU HAVE WON THE POKEMON GAME ");
                    }

                    else
                    {
                        Console.WriteLine("OH NO, You have lost against the enemy! ");
                    }

                }
                

                else if (choice == 2)
                {
                    

                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter in numbers only" + ex);

            }

            
             

            //while loop with the IsAlive function to see if the game loop will end 

            //water fire and grass pokemon

            //lists would be good here for opps and player pokemon
        }
    }
}
