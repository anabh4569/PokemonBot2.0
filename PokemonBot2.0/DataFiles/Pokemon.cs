using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0.DataFiles
{
    class Pokemon
    {
        public Pokemon(string name, double health, string status)
        {
            this.name = name;
            this.health = health;
            this.status = status;
        }

        public Pokemon() : this("", 0, "")
        {

        }

        protected string name;
        protected double health;
        protected string status;
        protected List<Type> typing = new List<Type>();
        protected List<Type> immune = new List<Type>();
        protected Type type1;
        protected Type type2;
        protected int estimatedSpeed; protected int estimatedHealth; protected int estimatedAttack; protected int estimatedDefense; protected int estimatedSpAttk; protected int estimatedSpDef;
        protected int attackboost = 0; protected int speedboost = 0; protected int spattkboost = 0; protected int defenseboost = 0; protected int spdefboost = 0; protected int critboost = 0;
        protected string item;
        protected Move move1; protected Move move2; protected Move move3; protected Move move4;
        protected List<Move> moves = new List<Move>();

        public double EstimatedHealth { get { return estimatedHealth; } }
        public double EstimatedAttack { get { return estimatedAttack; } }
        public double EstimatedDefense { get { return estimatedDefense; } }
        public double EstimatedSpAttk { get { return estimatedSpAttk; } }
        public double EstimatedSpDef { get { return estimatedSpDef; } }
        public double EstimatedSpeed { get { return estimatedSpeed; } }
        public double AttackBoost { get { return attackboost; } set { attackboost = Convert.ToInt32(value); } }
        public double SpeedBoost { get { return speedboost; } set { speedboost = Convert.ToInt32(value); } }
        public double SpAttkBoost { get { return spattkboost; } set { spattkboost = Convert.ToInt32(value); } }
        public double DefenseBoost { get { return defenseboost; } set { defenseboost = Convert.ToInt32(value); } }
        public double SpDefBoost { get { return spdefboost; } set { spdefboost = Convert.ToInt32(value); } }
        public double CritBoost { get { return critboost; } set { critboost = Convert.ToInt32(value); } }
        public string Name { get { return name; } set { name = value; } }
        public double Health { get { return health; } set { health = value; } }
        public string Status { get { return status; } set { status = value; } }
        public List<Move> Moves { get { return moves; } set { moves = value; } }
        public string Item { get { return item; } }

        public override string ToString()
        {
            return name + ": " + health.ToString() + "% with " + status + " status.";
        }

        protected void Initialize(string name, double health, string status)
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
            moves.Add(move1);
            moves.Add(move2);
            moves.Add(move3);
            moves.Add(move4);
        }

        protected virtual List<Type> GetImmunities()
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
