using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Client.Console
{
    using System;
    class Program
    {
        static void Main(string[] args)
        {
            //all aces are 11 points (real life we can choose between 1 or 11)
            //when we draw a card, house always draws a card (rl - house draws a card at the end)
            Console.WriteLine("Welcome to the game fo BlackJack");
            Console.WriteLine();

            //clubs, heart, spades, 
            Console.WriteLine("You have been dealt: 4C, 6H");
            Console.WriteLine("House has been dealt: 8S, [?]");
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
    }
}
