using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Keldeo : Pokemon
    {
        public Keldeo(double health, string status)
        {
            name = "Keldeo";
            type1 = new Water();
            type2 = new Fighting();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Keldeo() : this(100, "None")
        {

        }
    }
}
