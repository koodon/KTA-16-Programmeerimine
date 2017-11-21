using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core
{
    using System;
    public class Card
    {
        public string Description => rank + suite.GetShortName();
        //vaikimisi kõik kaardid peidetud
        public bool Hidden { get; set; }

        public readonly string rank;
        public readonly Suite suite;
        public readonly int points;

        public Card(string rank, Suite suite, int points, bool hidden = true)
        {
            this.rank = rank;
            this.suite = suite;
            this.points = points;

            this.Hidden = hidden;

            //Decription = Rank + Suite;
        }
    }
}
