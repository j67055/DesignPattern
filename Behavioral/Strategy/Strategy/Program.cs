using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Test("Cut Suffle", new CutSuffle<int>());
            Test("Riffle Suffle", new RiffleSuffle<int>());
            Test("Random Suffle", new RandomSufle<int>());
        }

        static void Test(string title, Suffle<int> suffleAlgorithm)
        {
            Console.WriteLine("\t" + title);
            Console.WriteLine("=================================");

            Deck deck = new Deck(10);
            deck.setSuffleAlgoritm(suffleAlgorithm);
            Console.Write("Before: ");
            deck.print();
            deck.suffle();
            Console.Write("After: ");
            deck.print();

            Console.WriteLine("=================================\n");
        }
    }
}
