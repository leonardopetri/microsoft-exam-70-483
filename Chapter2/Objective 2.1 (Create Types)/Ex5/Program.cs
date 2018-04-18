using System;
using System.Collections.Generic;
using System.Linq;

namespace Ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            var cardCollection = new List<Card>();
            Deck.NumberOfCards = 10;
            for (int i = 0; i < Deck.NumberOfCards; i++)
            {
                cardCollection.Add(new Card{ Number = i });
            }

            Deck deck = new Deck(cardCollection);
            var firstCard = deck[3];
            Console.WriteLine("First card's number in the Deck object is: {0}", firstCard.Number);
        }
    }

    public class Card
    {
        public int Number { get; set;}
    }

    public class Deck
    {
        public static int NumberOfCards = 42;
        public ICollection<Card> Cards { get; private set; }

        public Deck(ICollection<Card> Cards)
        {
            this.Cards = Cards;
        }

        public Card this[int index]
        {
            get { return Cards.ElementAt(index); }
        }
    }
}
