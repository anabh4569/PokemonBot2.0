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
        protected double power;
        protected Type typing;
        protected string name;
        protected string additionalEffects;

        public bool IsStatus { get { return isStatus; } }
        public double Power { get { return power; } }
        public string Name { get { return name; } }
        public string AdditionalEffects { get { return additionalEffects; } }
        public Type Typing { get { return typing; } }
    }
}
