using System;
using System.Collections.Generic;
using System.Text;

namespace DeckOCards
{
    public enum Suits
    {
        Clubs,
        Diamonds,
        Hearts,
        Spades
    }
    public enum Numbers
    {
        Ace,
        Two,
        Three,
        Four,
        Five,
        Six,
        Seven,
        Eight,
        Nine,
        Ten,
        Jack,
        Queen,
        King
    }
    public class Card
    {
        public Suits Suit { get; set; }
        public Numbers Number { get; set; }
    }
}
