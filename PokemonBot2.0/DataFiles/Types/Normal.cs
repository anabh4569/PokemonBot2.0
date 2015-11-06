using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Normal : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Fighting());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            return resist;
        }

        public override List<Type> getImmunities()
        {
            List<Type> immune = new List<Type>();
            immune.Add(new Ghost());
            return immune;
        }
    }
}
