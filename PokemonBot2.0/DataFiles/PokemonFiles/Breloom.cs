using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Breloom : Pokemon
    {
        public Breloom(double health, string status)
        {
            name = "Breloom";
            type1 = new Grass();
            type2 = new Fighting();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Breloom() : this(100, "None")
        {

        }
    }
}
