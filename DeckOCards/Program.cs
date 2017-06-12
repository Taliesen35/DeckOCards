using System;

namespace DeckOCards
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var deck = new Deck();
            Console.WriteLine(deck.ToString());

            while (true)
            {
                var s = Console.ReadLine();

                if (s == "shuffle")
                {
                    deck.Shuffle();
                    Console.WriteLine(deck.ToString());
                }
                else if (s == "sort")
                {
                    deck = new Deck();
                    Console.WriteLine(deck.ToString());
                }
            }
        }
    }
}