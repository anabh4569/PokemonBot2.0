using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Bisharp : Pokemon
    {
        public Bisharp(double health, string status)
        {
            name = "Bisharp";
            type1 = new Dark();
            type2 = new Steel();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Bisharp() : this(100, "None")
        {

        }
    }
}
