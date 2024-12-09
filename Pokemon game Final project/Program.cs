using System.ComponentModel.Design;
using System.Numerics;
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

                Console.WriteLine("In this game you will have an option to pick between 3 types of pokemon");

                Console.WriteLine();

                Console.WriteLine("Below are listed pokemon you can go agianst");

                Console.WriteLine();

                Console.WriteLine("You can go agianst a Grass type or Water type");

                Console.WriteLine();

                Pokemon[] pokemons = new GrassPokemon[2];
                pokemons[0] = new GrassPokemon("Bulbasaur");
                pokemons[1] = new GrassPokemon("Snivy");

                Console.WriteLine("Grass enemy options below");


                Console.WriteLine();

                foreach (var pokemon in pokemons)
                {
                    Console.WriteLine(pokemon);
                }

                Console.WriteLine("Water option below");

                Console.WriteLine();

                Pokemon[] Waterpokemon = new WaterPokemon[2];
                Waterpokemon[0] = new WaterPokemon("Squirtle");
                Waterpokemon[1] = new WaterPokemon("Sobble");

                foreach(var pokemon2 in Waterpokemon)
                {
                    Console.WriteLine(pokemon2);
                }

                

                Console.WriteLine();

                Console.WriteLine("Choose your pokemon for battle:");
                Console.WriteLine("1 - Fire type\n" + "2 - Water type\n" + "3 - Grass type\n");
                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Pokemon player = new FirePokemon("Charmander");//object creation for player pokemon
                    Pokemon enemy1 = new GrassPokemon("Bulbasaur");

                    Console.WriteLine("Player pokemon: " + player);
                    Console.WriteLine("Enemy pokemon: " + enemy1);

                    while(player.IsAlive() & enemy1.IsAlive())//keeps the game going as long as both enemy1 and player are above 0 Health
                    {
                        Console.WriteLine("Enter in your attack");
                        Console.WriteLine("\nChoose your action: 1. Attack");
                        string action = Console.ReadLine();

                        if (action == "1")
                        {
                            Console.WriteLine("Player Turn Description");

                            Console.WriteLine();
                            // Player attacks
                            Console.ForegroundColor = ConsoleColor.Green;
                            player.Attack(enemy1);

                            Console.WriteLine();

                            Console.ResetColor();

                            // Opponent attacks if still alive
                            if (enemy1.IsAlive())
                            {
                                Console.WriteLine("Enemy player turn Description");

                                Console.WriteLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                enemy1.Attack(player);
                                Console.ResetColor();

                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid action! You lost your turn.");
                        }
                    }
                    //determine winner
                    if (player.IsAlive()) // if player is above 0 hp then win or you lose 
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
                    Pokemon player1 = new WaterPokemon("Squirtle");
                    Pokemon enemy = new GrassPokemon("Snivy");

                    Console.WriteLine("Player Pokemon " + player1);
                    Console.WriteLine("Enemy Pokemon " + enemy);

                    while(player1.IsAlive() & enemy.IsAlive())
                    {
                        Console.WriteLine("Enter in your attack ");
                        Console.WriteLine("\nEnter in your action: 1. Attack");
                        string option = Console.ReadLine();

                        if (option == "1")
                        {
                            Console.WriteLine("Player Turn Description");

                            Console.WriteLine();

                            Console.ForegroundColor= ConsoleColor.Green;

                            player1.Attack(enemy);


                            Console.WriteLine();

                            Console.ResetColor();

                            if (enemy.IsAlive())
                            {
                                Console.WriteLine("Enemy Turn Description");

                                Console.WriteLine();

                                Console.ForegroundColor= ConsoleColor.Red;

                                enemy.Attack(player1);

                                Console.ResetColor();

                                Console.WriteLine();
                            }

                            
                        }
                        else
                        {
                            Console.WriteLine("Invalid action! You lost your turn.");
                        }



                    }
                    if (player1.IsAlive()) // if player is above 0 hp then win or you lose 
                    {
                        Console.WriteLine("CONGRATULATIONS YOU HAVE WON THE POKEMON GAME ");
                    }

                    else
                    {
                        Console.WriteLine("OH NO, You have lost against the enemy! ");
                    }
                }

                else if (choice == 3)
                {
                    Pokemon player = new GrassPokemon("Treeko");
                    Pokemon enemy = new WaterPokemon("Squirtle");

                    while (player.IsAlive() & enemy.IsAlive())//keeps the game going as long as both enemy1 and player are above 0 Health
                    {
                        Console.WriteLine("Enter in your attack");
                        Console.WriteLine("\nChoose your action: 1. Attack");
                        string action = Console.ReadLine();

                        if (action == "1")
                        {
                            Console.WriteLine("Player Turn Description");

                            Console.WriteLine();
                            // Player attacks
                            Console.ForegroundColor = ConsoleColor.Green;
                            player.Attack(enemy);

                            Console.WriteLine();

                            Console.ResetColor();

                            // Opponent attacks if still alive
                            if (enemy.IsAlive())
                            {
                                Console.WriteLine("Enemy player turn Description");

                                Console.WriteLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                enemy.Attack(player);
                                Console.ResetColor();

                                Console.WriteLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid action! You lost your turn.");
                        }
                    }
                    //determine winner
                    if (player.IsAlive()) // if player is above 0 hp then win or you lose 
                    {
                        Console.WriteLine("CONGRATULATIONS YOU HAVE WON THE POKEMON GAME ");
                    }

                    else
                    {
                        Console.WriteLine("OH NO, You have lost against the enemy! ");
                    }

                }
                else
                {
                    Console.WriteLine("Please enter in 1-3 please");
                }
                

                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Enter in numbers only + " + ex);

            }
            

            
             

            //while loop with the IsAlive function to see if the game loop will end 

            //water fire and grass pokemon

            //lists would be good here for opps and player pokemon
        }
    }
}
