using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Ground : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Grass());
            weak.Add(new Ice());
            weak.Add(new Water());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Poison());
            resist.Add(new Rock());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            List<Type> immune = new List<Type>();
            immune.Add(new Electric());
            return immune;
        }
    }
}
