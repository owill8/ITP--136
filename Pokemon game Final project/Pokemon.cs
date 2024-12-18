﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_game_Final_project
{
    public class Pokemon
    {
        public int Health
        {
            get { return health; }
            set
            {
                if (value < 0)
                {
                    health = 0;//makes so it does not show negative numbers
                }
                else
                {
                    health = value;
                }
            }
        }

        public int health;
        public string Name { get; set; }
        public int AttackPower { get; set; }

        public string Type  { get; set; }

        public Pokemon(int health, string name, int attack, string type)
        {
            Health  = health;
            Name = name;
            AttackPower = attack;
            Type = type;
        }

       

        public bool IsAlive()//function to tell the program whether or not the pokemon is above 0 health (alive)
        {
            return Health > 0;
        }

        public virtual void Attack(Pokemon enemy)//attack funtion to deal damage with enemy object
        {
            Console.WriteLine(Name + " " + " Attacks " + " " + enemy.Name);
            enemy.TakeDamage(AttackPower);//attack power determines damage on take damage method.
        }

        public void TakeDamage(int damage)//function to calculate damage for the attack method 
        {
            Health -= damage;
            Console.WriteLine(Name + " Takes " + damage + " DAMAGE!" + " Remaining Health: " + Health);

            if (!IsAlive())//if below 0 hp
            {
                Console.WriteLine(Name + " Has fainted");
            }
            else
            {
                Console.WriteLine(Name + " Is still healthy and ready to fight");
            }
                

             }
        public override string ToString()//displays type hp and attack power and name of pokemon
        {
            return Name + " - " + "Type: " + Type + " " + "HP:" + " " + Health + " " + "Attack Power: " + AttackPower;
        }

       

        

    }
}
