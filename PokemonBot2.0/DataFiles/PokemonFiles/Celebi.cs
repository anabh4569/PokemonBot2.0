using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Celebi : Pokemon
    {
        public Celebi(double health, string status)
        {
            name = "Celebi";
            type1 = new Grass();
            type2 = new Psychic();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Celebi() : this(100, "None")
        {

        }
    }
}
