using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Heracross : Pokemon
    {
        public Heracross(double health, string status)
        {
            name = "Heracross";
            type1 = new Fighting();
            type2 = new Bug();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Heracross() : this(100, "None")
        {

        }
    }
}
