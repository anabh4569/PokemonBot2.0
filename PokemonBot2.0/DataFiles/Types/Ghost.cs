using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Ghost : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Dark());
            weak.Add(new Ghost());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Bug());
            resist.Add(new Poison());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            List<Type> immune = new List<Type>();
            immune.Add(new Fighting());
            immune.Add(new Normal());
            return immune;
        }
    }
}
