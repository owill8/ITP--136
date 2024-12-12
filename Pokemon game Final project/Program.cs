using System;
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
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("--Welcome to Pokemon Text Battle game----");
                Console.WriteLine("-----------------------------------------");

                Console.WriteLine("In this game you will have an option to pick between 2 types of pokemon");

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

                Console.WriteLine();

                Console.WriteLine("Water enemy options below");

                Console.WriteLine();

                Pokemon[] Waterpokemon = new WaterPokemon[2];
                Waterpokemon[0] = new WaterPokemon("Squirtle");
                Waterpokemon[1] = new WaterPokemon("Sobble");

                foreach(var pokemon2 in Waterpokemon)
                {
                    Console.WriteLine(pokemon2);
                }

                

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Choose your pokemon for battle:(Enter 1,2,3) ");
                
                Console.WriteLine();
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

                        Console.WriteLine("You got the enemy down to the below hp: ");

                        Console.WriteLine();
                        Console.WriteLine("Health: " + enemy1.Health);
                    }

                }
                

                else if (choice == 2)
                {
                    Pokemon player1 = new WaterPokemon("Squirtle");
                    Pokemon enemy2 = new GrassPokemon("Snivy");

                    Console.WriteLine("Player Pokemon " + player1);
                    Console.WriteLine("Enemy Pokemon " + enemy2);

                    while(player1.IsAlive() & enemy2.IsAlive())
                    {
                        Console.WriteLine("Enter in your attack ");
                        Console.WriteLine("\nEnter in your action: 1. Attack");
                        string option = Console.ReadLine();

                        if (option == "1")
                        {
                            Console.WriteLine("Player Turn Description");

                            Console.WriteLine();

                            Console.ForegroundColor= ConsoleColor.Green;

                            player1.Attack(enemy2);


                            Console.WriteLine();

                            Console.ResetColor();

                            if (enemy2.IsAlive())
                            {
                                Console.WriteLine("Enemy Turn Description");

                                Console.WriteLine();

                                Console.ForegroundColor= ConsoleColor.Red;

                                enemy2.Attack(player1);

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

                        Console.WriteLine("You got the enemy down to the below hp: ");

                        Console.WriteLine();
                        Console.WriteLine("Health: " + enemy2.Health);
                    }
                }

                else if (choice == 3)
                {
                    Pokemon player = new GrassPokemon("Treeko");
                    Pokemon enemy3 = new WaterPokemon("Squirtle");

                    Console.WriteLine("Player Pokemon " + player);
                    Console.WriteLine("Enemy Pokemon " + enemy3);

                    Console.WriteLine();

                    while (player.IsAlive() & enemy3.IsAlive())//keeps the game going as long as both enemy1 and player are above 0 Health
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
                            player.Attack(enemy3);

                            Console.WriteLine();

                            Console.ResetColor();

                            // Opponent attacks if still alive
                            if (enemy3.IsAlive())
                            {
                                Console.WriteLine("Enemy player turn Description");

                                Console.WriteLine();

                                Console.ForegroundColor = ConsoleColor.Red;
                                enemy3.Attack(player);
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

                        Console.WriteLine("You got the enemy down to the below hp: ");

                        Console.WriteLine();
                        Console.WriteLine("Health: " + enemy3.Health);
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

            Console.WriteLine();

            Console.WriteLine("Thanks for playing my text Pokemon Game!");
            

            
             

            //while loop with the IsAlive function to see if the game loop will end 

            //water fire and grass pokemon

            //lists would be good here for opps and player pokemon
        }
    }
}
