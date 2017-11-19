using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dice_Roller_Class
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine("");

            DiceRoller diceRoller = new DiceRoller();
            List<DiceRoll> diceRolls = diceRoller.Roll(
                new List<Dice> { Dice.D6, Dice.D6, Dice.D6, Dice.D8, Dice.D8});

            foreach (var diceRoll in diceRolls)
            {
                Console.WriteLine($"1{diceRoll.Dice}: {diceRoll.Value}");
            }
            Console.ReadLine();

            /*
            Dice d6 = new Dice(6, "d6");
            Dice d8 = new Dice(8, "d8");

            var total = 0;

            //var d6 = Dice.D6;
            for (var i = 0; i < 3; i++)
            {
                var roll = d6.Roll(6);
                total += roll;

                Console.WriteLine($"1{d6.Description}: { roll }");
            }

            //var d8 = Dice.D6;
            for (var i = 0; i < 2; i++)
            {
                var roll = d8.Roll(8);
                total += roll;
                Console.WriteLine($"1{d8.Description}: { roll }");
            }

            Console.WriteLine("");
            Console.WriteLine($"Roll total: { diceRolls.Sum(x => x.Value) }");
            Console.WriteLine("");
            Console.ReadLine();
            */
        }
    }
}
