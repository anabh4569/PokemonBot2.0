using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles
{
    class Type
    {
        public Type()
        {

        }

        public override string ToString()
        {
            string dog = this.GetType().ToString();
            return dog.Substring(dog.LastIndexOf(".") + 1);
        }

        public virtual List<Type> getWeaknesses()
        {
            return new List<Type>();
        }

        public virtual List<Type> getResistances()
        {
            return new List<Type>();
        }

        public virtual List<Type> getImmunities()
        {
            return new List<Type>();
        }
    }
}
