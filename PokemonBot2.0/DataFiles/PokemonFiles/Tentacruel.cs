using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Tentacruel : Pokemon
    {
        public Tentacruel(double health, string status)
        {
            name = "Tentacruel";
            type1 = new Water();
            type2 = new Poison();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Tentacruel() : this(100, "None")
        {

        }
    }
}
