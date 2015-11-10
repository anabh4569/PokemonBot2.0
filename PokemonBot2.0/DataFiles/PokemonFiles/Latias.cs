using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Latias : Pokemon
    {
        public Latias(double health, string status)
        {
            name = "Latias";
            type1 = new Psychic();
            type2 = new Dragon();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Latias() : this(100, "None")
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
            immune.Add(new Ground());
            return immune;
        }
    }
}
