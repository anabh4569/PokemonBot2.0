﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types;

namespace PokemonBot2._0.DataFiles.PokemonFiles
{
    class Venusaur : Pokemon
    {
        public Venusaur(double health, string status)
        {
            name = "Venusaur";
            type1 = new Grass();
            type2 = new Poison();
            Initialize(name, health, status);
            estimatedSpeed = 309; estimatedHealth = 309; estimatedAttack = 309; estimatedDefense = 309; estimatedSpAttk = 309; estimatedSpDef = 309;
        }

        public Venusaur() : this(100, "None")
        {

        }
    }
}
