using System;

namespace codeassignment
{
    class Program
    {
        static void Main(string[] args)
        {

            // Create deck which populates in Bicycle NDO order
            Deck cardDeck = new Deck();

            // Output each step of exercise
            Console.WriteLine("");
            Console.WriteLine("Shiftwise Code Challenge");
            Console.WriteLine("Card suits are represented by the first character of the suite (example: H = Hearts)");
            Console.WriteLine("Face cards and aces are represented by the first character of the card name (example: J = Jack)");
            Console.WriteLine("");
            Console.WriteLine("Start with a deck in Bicycle NDO (New Deck Order)");
            Console.WriteLine(cardDeck.Show());
            Console.WriteLine("");
            Console.WriteLine("Shuffle the deck in random order using Knuth algorithm");
            cardDeck.Shuffle();
            Console.WriteLine(cardDeck.Show());
            Console.WriteLine("");
            Console.WriteLine("Sort the deck in ascending order");
            cardDeck.Sort();
            Console.WriteLine(cardDeck.Show());
            Console.WriteLine("");
        }
    }
}