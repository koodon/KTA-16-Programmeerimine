using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Dice_Roller_Random
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr6 = new Random().Next(1, 6);
            int nr8 = new Random().Next(1, 8);
            Console.WriteLine("> /roll 3d6 2d8");
            Console.WriteLine("");
            Console.WriteLine("1d6: " + nr6);
            Console.WriteLine("1d6: " + nr6);
            Console.WriteLine("1d6: " + nr6);
            Console.WriteLine("1d8: " + nr8);
            Console.WriteLine("1d8: " + nr8);
            Console.WriteLine("");
            Console.WriteLine("Roll total: 20");
            Console.ReadLine();
        }
    }
}
