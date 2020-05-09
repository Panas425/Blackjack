using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCardLib
{
    /// <typeparam name="T"></typeparam>
    public class Deck<T> : IDeck<T>
    {
        /// <summary>
        /// Delecering variables
        /// </summary>
        public int Count => DeckPile.Count;
        public List<T> DeckPile { get; set; } = new List<T>();
        public List<T> DiscardPile { get; set; } = new List<T>();
        private Random random = new Random();

        /// <summary>
        /// Add cards to the deck
        /// </summary>
        /// <param name="cardList"></param>
        public void AddCards(List<T> cardList)
        {
            DeckPile.AddRange(cardList);
        }

        /// <summary>
        /// Temporarily stores the card, adds it to the discard pile, removes the real card object from the deck pile and 
        /// returns the card
        /// </summary>
        /// <returns></returns>
        public T DrawNextCard()
        {
            T card = DeckPile[Count - 1];
            DiscardPile.Add(card);
            DeckPile.RemoveAt(Count - 1);

            if (Count == 0)
            {
                ReShuffleDeck();
            }
            return card;
        }

        /// <summary>
        /// Reshuffle all the cards into the deck
        /// </summary>
        public void ReShuffleDeck()
        {
            DeckPile.AddRange(DiscardPile);
            DiscardPile.Clear();
            ShuffleDeck();
        }

        /// <summary>
        /// Swaps position of two objects in the list
        /// </summary>
        /// <param name="dataList"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public void SwapCards(List<T> dataList, int a, int b)
        {
            T temp = dataList[a];
            dataList[a] = dataList[b];
            dataList[b] = temp;
        }

        /// <summary>
        /// Shuffle the cards in the deck
        /// </summary>
        public void ShuffleDeck()
        {
            int randomIndex;

            for (int currentIndex = 0; currentIndex < Count; currentIndex++)
            {
                do
                {
                    randomIndex = random.Next(0, Count);
                }
                while (randomIndex == currentIndex);
                SwapCards(DeckPile, currentIndex, randomIndex);
            }
        }




    }
}
