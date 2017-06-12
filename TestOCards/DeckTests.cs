using System.Collections;
using System.Collections.Generic;
using DeckOCards;
using System.Linq;
using NUnit.Framework;


namespace TestOCards
{
    [TestFixture]
    public class DeckTests
    {
        [Test]
        public void TestNoShuffleOrderIsTheSame()
        {
            var deck = new Deck();
            var testDeck = new Deck();
            
            Assert.AreEqual(testDeck.ToString(), deck.ToString());
        }
        [Test]
        public void TestShuffleChangesOrder()
        {
            var deck = new Deck();
            var testDeck = new Deck();

            testDeck.Shuffle();
            Assert.AreNotEqual(testDeck.ToString(), deck.ToString());
        }
    }
}
