using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Water : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Electric());
            weak.Add(new Grass());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Fire());
            resist.Add(new Ice());
            resist.Add(new Steel());
            resist.Add(new Water());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            return new List<Type>();
        }
    }
}
