﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Dragonite : Pokemon
    {
        public Dragonite(double health, string status)
        {
            name = "Dragonite";
            type1 = new Flying();
            type2 = new Dragon();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Dragonite() : this(100, "None")
        {

        }
    }
}
