using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Fairy : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Poison());
            weak.Add(new Steel());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Bug());
            resist.Add(new Dark());
            resist.Add(new Fighting());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            List<Type> immune = new List<Type>();
            immune.Add(new Dragon());
            return immune;
        }
    }
}
