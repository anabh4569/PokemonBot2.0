using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Shedinja : Pokemon
    {
        public Shedinja(double health, string status)
        {
            name = "Shedinja";
            type1 = new Bug();
            type2 = new Ghost();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309; move1 = new Flamethrower(); move2 = new Flamethrower(); move3 = new Flamethrower(); move4 = new Flamethrower();
        }

        public Shedinja() : this(100, "None")
        {

        }

        protected override List<Type> GetImmunities()
        {
            List<Type> immune = new List<Type>();
            foreach (Type a in typing)
            {
                foreach (Type b in a.getImmunities())
                {
                    immune.Add(b);
                }
            }
            immune.Add(new Bug());
            immune.Add(new Ground());
            immune.Add(new Grass());
            immune.Add(new Poison());
            immune.Add(new Steel());
            immune.Add(new Water());
            immune.Add(new Fairy());
            immune.Add(new Ice());
            immune.Add(new Dragon());
            immune.Add(new Electric());
            immune.Add(new Psychic());
            return immune;
        }
    }
}
