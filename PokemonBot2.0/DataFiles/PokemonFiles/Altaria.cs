using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Altaria : Pokemon
    {
        public Altaria(double health, string status)
        {
            name = "Altaria";
            type1 = new Flying();
            type2 = new Dragon();
            
            estimatedSpeed = 259;
            estimatedHealth = 291;
            estimatedAttack = 262;
            estimatedDefense = 217;
            estimatedSpAttk = 158;
            estimatedSpDef = 259;
            move1 = new Roost();
            move2 = new Return();
            move3 = new Earthquake();
            move4 = new DragonDance();
            Initialize(name, health, status);
            item = "Altarianite";
        }

        public Altaria() : this(100, "None")
        {

        }
    }
}
