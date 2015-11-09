using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Entei : Pokemon
    {
        public Entei(double health, string status)
        {
            name = "Entei";
            type1 = new Fire();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Entei() : this(0, "")
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
        private int estimatedSpeed; private int estimatedHealth; private int estimatedAttack; private int estimatedDefense; private int estimatedSpAttk; private int estimatedSpDef; public double EstimatedHealth { get { return estimatedHealth; } } public double EstimatedAttack { get { return estimatedAttack; } } public double EstimatedDefense { get { return estimatedDefense; } } public double EstimatedSpAttk { get { return estimatedSpAttk; } } public double EstimatedSpDef { get { return estimatedSpDef; } } public double EstimatedSpeed { get { return estimatedSpeed; } } 
        private List<Type> immune = new List<Type>();
        private Type type1;
        private Type type2;

        

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
