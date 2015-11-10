using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Diancie : Pokemon
    {
        public Diancie(double health, string status)
        {
            name = "Diancie";
            type1 = new Rock();
            type2 = new Fairy();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Diancie() : this(100, "None")
        {

        }
    }
}
