using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0
{
    class Pokemon
    {
        public Pokemon(string name, double health, string status)
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
        }

        public Pokemon()
        {
            this.name = "";
            this.health = 0;
            this.status = "";
        }

        string name;
        double health;
        string status;
        Type type1;
        Type type2;
        List<Type> typing = new List<Type>();
        int maxSpeed;

        public string Name { get { return name; } set { name = value; } }
        public double Health { get { return health; } set { health = value; } }
        public string Status { get { return status; } set { status = value; } }
        public List<Type> Typing { get { return typing; } set { typing = value; } }
        public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }

        public override string ToString()
        {
            return name + ": " + health.ToString() + "% with " + status + " status.";
        }

        public List<Type> GetImmunities()
        {
            List<Type> immune = new List<Type>();
            foreach (Type a in typing)
            {
                foreach (Type b in a.getImmunities())
                {

                }
            }
            return immune;
        }
    }
}
