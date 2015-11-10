using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Starmie : Pokemon
    {
        public Starmie(double health, string status)
        {
            name = "Starmie";
            type1 = new Psychic();
            type2 = new Water();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Starmie() : this(100, "None")
        {

        }
    }
}
