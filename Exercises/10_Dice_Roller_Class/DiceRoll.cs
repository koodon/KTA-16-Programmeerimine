﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dice_Roller_Class
{
    public class DiceRoll
    {
        public string Dice { get; }

        public int Value { get; }

        public DiceRoll(string dice, int value)
        {
            this.Dice = dice;
            this.Value = value;
        }
    }
}
