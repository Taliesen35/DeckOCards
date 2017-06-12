using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DeckOCards
{

    public class Deck
    {
        private Random _random;
        public List<Card> BaseDeck { get; set; }

        public Deck()
        {
            BaseDeck = CreateBaseDeck();    
        }

        public List<Card> CreateBaseDeck()
        {
            return(from s in Enum.GetNames(typeof(Suits))
                from v in Enum.GetNames(typeof(Numbers))
                select new Card
                {
                    Suit = (Suits) Enum.Parse(typeof(Suits), s),
                    Number = (Numbers) Enum.Parse(typeof(Numbers), v)
                }
            ).ToList();
        }

        public void Shuffle()
        {
            _random = new Random(DateTime.Now.Millisecond);

            for ( var i = 0; i < BaseDeck.Count; i++ )
            {
                var tempCard = BaseDeck[_random.Next(0, 52)];
                BaseDeck.Remove(tempCard);
                BaseDeck.Insert(_random.Next(0, 51), tempCard);
            }
        }

        public override string ToString()
        {
            var b = new StringBuilder();

            foreach (var c in BaseDeck)
            {
                b.Append($"{c.Number} of {c.Suit}{Environment.NewLine}");
            }

            return b.ToString();
        }
    }
}
