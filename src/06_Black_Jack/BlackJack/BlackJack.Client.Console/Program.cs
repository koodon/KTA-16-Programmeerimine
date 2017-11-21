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
            var cards = new List<Card>
            {

            };

            Console.WriteLine("Welcome to the game fo BlackJack");
            Console.WriteLine();
            var C4 = new Card("4", Suite.Clubs, 4, false);
            //C4.Hidden = false;
            var H6 = new Card("6", Suite.Heart, 6, false);
            //H6.Hidden = false;
            var S8 = new Card("8", Suite.Spade, 8, false);
            //S8.Hidden = false;
            var DJ = new Card("J", Suite.Diamond, 10);

            Console.WriteLine($"You have been dealt: {GetCardDescription(C4)}, {GetCardDescription(H6)}");
            Console.WriteLine($"You have been dealt: {GetCardDescription(S8)}, {GetCardDescription(DJ)}");
            Console.WriteLine();

            var S4 = new Card("4", Suite.Spade, 4);
            C4.Hidden = false;
            var HD = new Card("H", Suite.Diamond, 10);         

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

        public static string GetCardDescription(Card card)
        {
            return card.Hidden ? "[?]" : card.Description;
        }    
    }
}
