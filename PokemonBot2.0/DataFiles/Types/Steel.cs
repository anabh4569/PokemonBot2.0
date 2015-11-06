using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles.Types
{
    class Steel : Type
    {
        public override List<Type> getWeaknesses()
        {
            List<Type> weak = new List<Type>();
            weak.Add(new Fighting());
            weak.Add(new Fire());
            weak.Add(new Ground());
            return weak;
        }

        public override List<Type> getResistances()
        {
            List<Type> resist = new List<Type>();
            resist.Add(new Bug());
            resist.Add(new Dragon());
            resist.Add(new Fairy());
            resist.Add(new Flying());
            resist.Add(new Grass());
            resist.Add(new Ice());
            resist.Add(new Normal());
            resist.Add(new Steel());
            resist.Add(new Rock());
            resist.Add(new Psychic());
            return resist;
        }

        public override List<Type> getImmunities()
        {
            List<Type> immune = new List<Type>();
            immune.Add(new Poison());
            return immune;
        }
    }
}
