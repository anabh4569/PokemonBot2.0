using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Weavile : Pokemon
    {
        public Weavile(double health, string status)
        {
            name = "Weavile";
            type1 = new Dark();
            type2 = new Ice();
            
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309; move1 = new Flamethrower(); move2 = new Flamethrower(); move3 = new Flamethrower(); move4 = new Flamethrower(); Initialize(name, health, status);
        }

        public Weavile() : this(100, "None")
        {

        }
    }
}
