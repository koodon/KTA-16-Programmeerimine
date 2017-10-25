using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dice_Roller_Total
{
    class Dice
    {
        public int Roll(int sides)
        {
            return new Random().Next(1, sides + 1);
        }
    }
}
