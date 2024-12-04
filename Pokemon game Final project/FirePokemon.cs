using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_game_Final_project
{
    public class FirePokemon : Pokemon
    {
        public FirePokemon(string name) : base(100, name, 50, "Fire") { } //constructor that inheritance through Pokemon class and sets the base stats of the fire Pokmeon//Health/FirePokemonname/Attackdamage/Type - Fire

        public override void Attack(Pokemon enemy)
        {
            base.Attack(enemy);
        }
    }
}
