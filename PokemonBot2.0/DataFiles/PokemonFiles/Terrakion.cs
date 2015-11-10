using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Terrakion : Pokemon
    {
        public Terrakion(double health, string status)
        {
            name = "Terrakion";
            type1 = new Rock();
            type2 = new Fighting();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Terrakion() : this(100, "None")
        {

        }
    }
}
