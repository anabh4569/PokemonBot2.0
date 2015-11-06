using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles
{
    abstract class Type
    {
        public Type()
        {

        }

        public override string ToString()
        {
            return this.GetType().ToString();
        }

        private string name;
        public abstract List<Type> getWeaknesses();
        public abstract List<Type> getResistances();
        public abstract List<Type> getImmunities();
    }
}
