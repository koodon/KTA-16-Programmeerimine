using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack.Core
{
    public class Deck
    {
        private readonly List<Card> cards;

        public Deck(List<Card> cards)
        {
            this.cards = cards;
        }

        public static Deck C36()
        {
            throw new NotImplementedException();
        }

        public static Deck C52()
        {
            throw new NotImplementedException();
        }

        public Card Next()
        {
            var card = cards.ElementAt(0);
            cards.RemoveAt(0);
            return card;        }
    }
}
