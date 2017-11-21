using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core
{
    public class Card
    {
        public string Description => Rank + Suite;
        //vaikimisi kõik kaardid peidetud
        public bool Hidden { get; set; } = true;

        public string Rank;
        public char Suite;
        public int Points;

        public Card(string rank, char suite, int points)
        {
            this.Rank = rank;
            this.Suite = suite;
            this.Points = points;

            //Decription = Rank + Suite;
        }
    }
}
