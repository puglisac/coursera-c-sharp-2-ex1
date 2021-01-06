using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleCards;

namespace Exercise1
{
    /// <summary>
    /// Exercise 1 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Practices using arrays
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {

            Deck deck = new Deck();
            Card[] cardArray = new Card[5];

            deck.Shuffle();

            //add top card to array, flip over, print card
            cardArray[0] = deck.TakeTopCard();
            cardArray[0].FlipOver();
            cardArray[0].Print();

            cardArray[1] = deck.TakeTopCard();
            cardArray[1].FlipOver();

            //print both cards in array
            for (int i = 0; i < 2; i++)
            {
                cardArray[i].Print();
            }

            //add 5 cards to array, flip over, print card
            for (int i = 0; i < 5; i++)
            {
                cardArray[i] = deck.TakeTopCard();
                cardArray[i].FlipOver();
                cardArray[i].Print();
            }

        }
    }
}
