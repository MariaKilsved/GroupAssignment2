using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;
        
        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                return cards[idx];
            }
        }

        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < Count; i++)
            {
                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
            var rnd = new Random(); //rnd is now a random generator - see .NET documentation

            for(int i = 0; i < 1000; i++)
            {
                int idx1 = rnd.Next(0, 52);
                int idx2 = rnd.Next(0, 52);
                while (idx1 == idx2)
                {
                    idx2 = rnd.Next(0, 52);
                }

                (cards[idx1], cards[idx2]) = (cards[idx2], cards[idx1]);
            }
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;



            //YOUR CODE
            //to initialize a fresh deck of cards
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards ()
        {
            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards

            for(int i = 0; i < 52; i++)
            {
                PlayingCardColor color;
                PlayingCardValue value;

                if(i < 13)
                {
                    color = PlayingCardColor.Clubs;
                    value = (PlayingCardValue)(i + 2);
                }
                else if(i >= 13 && i < 26)
                {
                    color = PlayingCardColor.Diamonds;
                    value = (PlayingCardValue)(i - 11);

                }
                else if (i >= 26 && i < 39)
                {
                    color = PlayingCardColor.Hearts;
                    value = (PlayingCardValue)(i - 24);
                }
                else
                {
                    color = PlayingCardColor.Spades;
                    value = (PlayingCardValue)(i - 37);
                }

                PlayingCard card = new PlayingCard(color, value);
                cards[i] = card;
            }

            
        }
    }
}