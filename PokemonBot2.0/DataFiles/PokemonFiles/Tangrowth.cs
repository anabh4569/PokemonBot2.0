using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Tangrowth : Pokemon
    {
        public Tangrowth(double health, string status)
        {
            name = "Tangrowth";
            type1 = new Flying();
            type2 = new Ground();
            Initialize(name, health, status);
            maxSpeed = 309;
        }

        public Tangrowth() : this(0, "")
        {

        }

        public void Initialize(string name, double health, string status)
        {
            this.name = name;
            this.health = health;
            this.status = status;
            if (type2 == null)
            {
                typing.Add(type1);
            }
            else
            {
                typing.Add(type1);
                typing.Add(type2);
            }
            immune = GetImmunities();
        }

        private List<Type> typing = new List<Type>();
        private int maxSpeed;
        private List<Type> immune = new List<Type>();
        private Type type1;
        private Type type2;

        public double MaxSpeed { get { return maxSpeed; } }

        private List<Type> GetImmunities()
        {
            List<Type> immune = new List<Type>();
            foreach (Type a in typing)
            {
                foreach (Type b in a.getImmunities())
                {
                    immune.Add(b);
                }
            }
            return immune;
        }

        public WeakEntry GetWeaknesses()
        {
            WeakEntry weak = new WeakEntry(type1, type2, GetImmunities());
            return weak;
        }
    }
}
