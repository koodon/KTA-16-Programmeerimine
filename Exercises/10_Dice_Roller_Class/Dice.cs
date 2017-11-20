using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ctrl+.
namespace _10_Dice_Roller_Class
{
    public class Dice
    {
        public int Sides { get; }

        public string Description { get; }
        //readonly saan anda väärtused ja neid kasutada aga mitte peale seda enam muuta ei saa
        //private static readonly Random Random = new Random();
        private static Random Random { get; } = new Random();

        public Dice(int sides, string description)
        {
            this.Sides = sides;
            //this.Random = new Random();
            this.Description = description;
        }

        public static Dice D6 => new Dice(6, "d6");
        public static Dice D8 => new Dice(6, "d8");

        //public static Dice D4
        //{
        //    return new Dice(4, "d4");
        //}

        //public int Roll(int Sides)
        public int Roll()
        {
            return Random.Next(1, this.Sides + 1);
        }
    }
}
