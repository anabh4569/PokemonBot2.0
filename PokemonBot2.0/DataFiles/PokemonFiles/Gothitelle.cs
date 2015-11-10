using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Gothitelle : Pokemon
    {
        public Gothitelle(double health, string status)
        {
            name = "Gothitelle";
            type1 = new Psychic();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Gothitelle() : this(100, "None")
        {

        }
    }
}
