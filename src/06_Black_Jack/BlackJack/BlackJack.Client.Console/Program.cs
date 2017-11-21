using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Client.Console
{
    using System;
    using BlackJack.Core;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the game fo BlackJack");
            Console.WriteLine();
            var C4 = new Card("4", 'C', 4);
            var H6 = new Card("6", 'H', 6);
            var S8 = new Card("8", 'S', 8);
            var DJ = new Card("J", 'D', 10);

            Console.WriteLine($"You have been dealt: {C4.Description}, {H6.Description}");
            Console.WriteLine($"You have been dealt: {S8.Description}, {(DJ.Hidden ? "[?]" : DJ.Description)}");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose 1 - Take another card");
            Console.WriteLine("Choose 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 1");

            Console.WriteLine();

            Console.WriteLine("You have been dealt: 4S");
            Console.WriteLine("House has been dealt");
            Console.WriteLine();

            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Choose 1 - Take another card");
            Console.WriteLine("Choose 2 - To finish");
            Console.WriteLine();
            Console.WriteLine("I choose: 2");

            Console.WriteLine("You have 14 points vs house 17");
            Console.WriteLine("House wins!");

            Console.WriteLine("Press any key");
            Console.ReadLine();
        }

        public static string Tutu(Card card)
        {

        }
    }
}
