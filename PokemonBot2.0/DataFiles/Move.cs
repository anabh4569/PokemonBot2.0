using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles
{
    class Move
    {
        protected bool isStatus;
        protected bool isPhysical;
        protected double power;
        protected Type typing;
        protected string name;
        protected string additionalEffects;
        protected int accuracy;
        protected int priority;

        public bool IsStatus { get { return isStatus; } }
        public bool IsPhysical { get { return isPhysical; } }
        public double Power { get { return power; } }
        public string Name { get { return name; } }
        public string AdditionalEffects { get { return additionalEffects; } }
        public Type Typing { get { return typing; } }
        public int Accuracy { get { return accuracy; } }
        public int Priority { get { return priority; } }
    }
}
