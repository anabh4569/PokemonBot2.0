using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class LandorusT : Pokemon
    {
        public LandorusT(double health, string status)
        {
            name = "LandorusT";
            type1 = new Flying();
            type2 = new Ground();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public LandorusT() : this(100, "None")
        {

        }
    }
}
