using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonBot2._0
{
    class PokemonEntry
    {
        public PokemonEntry(string name, double health, string status)
        {
            this.name = name;
            this.health = health;
            this.status = status;
        }

        public PokemonEntry()
        {
            this.name = "";
            this.health = 0;
            this.status = "";
        }

        string name;
        double health;
        string status;

        public string Name { get { return name; } set { name = value; } }
        public double Health { get { return health; } set { health = value; } }
        public string Status { get { return status; } set { status = value; } }

        public override string ToString()
        {
            return name + ": " + health.ToString() + "% with " + status + " status.";
        }
    }
}
