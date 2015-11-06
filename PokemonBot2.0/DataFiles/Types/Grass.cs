using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Grass : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Bug());
            weak.Add(new Fire());
            weak.Add(new Flying());
            weak.Add(new Ice());
            weak.Add(new Poison());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Ground());
            resist.Add(new Electric());
            resist.Add(new Water());
            resist.Add(new Grass());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            return new List<Type>();
        }
    }
}
