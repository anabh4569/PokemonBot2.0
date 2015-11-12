﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PokemonBot2._0.DataFiles.Types; using PokemonBot2._0.DataFiles.Moves;

namespace PokemonBot2._0.DataFiles.Moves
{
    class Scald : Move
    {
        public Scald()
        {
            isStatus = false;
            isPhysical = false;
            power = 90;
            name = "Scald";
            typing = new Fire();
            additionalEffects = "10% Burn";
            accuracy = 100;
            priority = 0;
        }
    }
}
