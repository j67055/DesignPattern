using System;
using System.Collections.Generic;
using System.Linq;

namespace Strategy
{
    class Deck
    {
        private List<int> cards;
        private Suffle<int> suffleAlgorithm;

        public Deck(int count)
            => cards = Enumerable.Range(0, count).ToList();

        public void setSuffleAlgoritm(Suffle<int> suffleAlgorithm)
            => this.suffleAlgorithm = suffleAlgorithm;

        public void suffle()
            => cards = suffleAlgorithm.suffle(cards);

        public void print()
        {
            foreach (int i in cards)
            {
                Console.Write(i.ToString());
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
