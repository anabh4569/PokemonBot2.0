using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Amoonguss : Pokemon
    {
        public Amoonguss(double health, string status)
        {
            name = "Amoonguss";
            type1 = new Grass();
            type2 = new Poison();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Amoonguss() : this(100, "None")
        {

        }
    }
}
