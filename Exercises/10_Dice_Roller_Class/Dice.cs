using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dice_Roller_Class
{
    public class Dice
    {

        //public Random Random { get; }

        //private int Sides { get; }

        public string Description;

        private static readonly Random Random = new Random();

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            this.Random = new Random();
            this.Description = description;
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(6, "d8");

        public int Roll(int Sides)
        {
            return Random.Next(1, this.Sides + 1);
        }
    }
}
