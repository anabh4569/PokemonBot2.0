using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Alakazam : Pokemon
    {
        public Alakazam(double health, string status)
        {
            name = "Alakazam";
            type1 = new Psychic();
            
            estimatedSpeed = 372;
            estimatedHealth = 251;
            estimatedAttack = 122;
            estimatedDefense = 127;
            estimatedSpAttk = 369;
            estimatedSpDef = 226;
            move1 = new PsychicA();
            move2 = new ShadowBall();
            move3 = new FocusBlast();
            move4 = new DazzlingGleam();
            Initialize(name, health, status);
            item = "Life Orb";
        }

        public Alakazam() : this(100, "None")
        {

        }
    }
}
