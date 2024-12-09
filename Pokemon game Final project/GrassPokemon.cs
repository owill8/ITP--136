using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_game_Final_project
{
    public class GrassPokemon : Pokemon
    {
        public GrassPokemon(string name) : base(240, name,33, "Grass")
        {

        }
        //override parent class attack
        public override void Attack(Pokemon enemy)
        {
            base.Attack(enemy); 
        }
    }
}
