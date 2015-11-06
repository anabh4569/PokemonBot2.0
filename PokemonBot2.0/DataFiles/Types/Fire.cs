using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Fire : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Ground());
            weak.Add(new Rock());
            weak.Add(new Water());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Bug());
            resist.Add(new Fairy());
            resist.Add(new Fire());
            resist.Add(new Grass());
            resist.Add(new Ice());
            resist.Add(new Steel());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            return new List<Type>();
        }
    }
}
