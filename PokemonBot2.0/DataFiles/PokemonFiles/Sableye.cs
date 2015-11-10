using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Sableye : Pokemon
    {
        public Sableye(double health, string status)
        {
            name = "Sableye";
            type1 = new Ghost();
            type2 = new Dark();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Sableye() : this(100, "None")
        {

        }
    }
}
