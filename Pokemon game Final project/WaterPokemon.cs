using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_game_Final_project
{
    public class WaterPokemon : Pokemon

    {
        public WaterPokemon(string name) : base(200,name,50, "Water")
        {

        }
        //override attack from parent
        public override void Attack(Pokemon enemy)
        {
            base.Attack(enemy);
        }
    }
}
