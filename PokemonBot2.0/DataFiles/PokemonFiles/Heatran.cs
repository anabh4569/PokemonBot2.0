using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Heatran : Pokemon
    {
        public Heatran(double health, string status)
        {
            name = "Heatran";
            type1 = new Fire();
            type2 = new Steel();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309; move1 = new Flamethrower(); move2 = new Flamethrower(); move3 = new Flamethrower(); move4 = new Flamethrower();
        }

        public Heatran() : this(100, "None")
        {

        }
    }
}
