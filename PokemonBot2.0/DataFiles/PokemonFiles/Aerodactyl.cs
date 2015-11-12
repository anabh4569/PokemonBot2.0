using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Aerodactyl : Pokemon
    {
        public Aerodactyl(double health, string status)
        {
            name = "Aerodactyl";
            type1 = new Flying();
            type2 = new Rock();
            
            estimatedSpeed = 385;
            estimatedHealth = 301;
            estimatedAttack = 308;
            estimatedDefense = 177;
            estimatedSpAttk = 140;
            estimatedSpDef = 186;
            move1 = new AerialAce();
            move2 = new IceFang();
            move3 = new FireFang();
            move4 = new StoneEdge();
            Initialize(name, health, status);
            item = "Aerodactylite";
        }

        public Aerodactyl() : this(100, "None")
        {

        }
    }
}
