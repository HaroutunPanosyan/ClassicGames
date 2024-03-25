using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SimpleGames.Deck
{
    public class Deck
    {
        public Deck()
        {
            NewDeck();
        }
        //public static void Reset()
        //{
        //    Console.WriteLine("Card(chooseSuit.Next(1,4)); chooseRank.Next(2,15)");
        //}
        //// Implementation with a List and HashSet.
        public static List<Card> NewDeck()
        {
            List<Card> cards = new List<Card>(52);

            #region ManualCardAddition
            // Manually adding each card.
            // 1.
            cards.Add(new Card(1, 2));
            cards.Add(new Card(1, 3));
            cards.Add(new Card(1, 4));
            cards.Add(new Card(1, 5));
            // 5.
            cards.Add(new Card(1, 6));
            cards.Add(new Card(1, 7));
            cards.Add(new Card(1, 8));
            cards.Add(new Card(1, 9));
            cards.Add(new Card(1, 10));
            // 10.
            cards.Add(new Card(1, 11));
            cards.Add(new Card(1, 12));
            cards.Add(new Card(1, 13));
            cards.Add(new Card(1, 14));
            cards.Add(new Card(2, 2));
            // 15.
            cards.Add(new Card(2, 3));
            cards.Add(new Card(2, 4));
            cards.Add(new Card(2, 5));
            cards.Add(new Card(2, 6));
            cards.Add(new Card(2, 7));
            // 20,
            cards.Add(new Card(2, 8));
            cards.Add(new Card(2, 9));
            cards.Add(new Card(2, 10));
            cards.Add(new Card(2, 11));
            cards.Add(new Card(2, 12));
            // 25.
            cards.Add(new Card(2, 13));
            cards.Add(new Card(2, 14));
            cards.Add(new Card(3, 2));
            cards.Add(new Card(3, 3));
            cards.Add(new Card(3, 4));
            // 30.
            cards.Add(new Card(3, 5));
            cards.Add(new Card(3, 6));
            cards.Add(new Card(3, 7));
            cards.Add(new Card(3, 8));
            cards.Add(new Card(3, 9));
            // 35.
            cards.Add(new Card(3, 10));
            cards.Add(new Card(3, 11));
            cards.Add(new Card(3, 12));
            cards.Add(new Card(3, 13));
            cards.Add(new Card(3, 14));
            // 40.
            cards.Add(new Card(4, 2));
            cards.Add(new Card(4, 3));
            cards.Add(new Card(4, 4));
            cards.Add(new Card(4, 5));
            cards.Add(new Card(4, 6));
            // 45.
            cards.Add(new Card(4, 7));
            cards.Add(new Card(4, 8));
            cards.Add(new Card(4, 9));
            cards.Add(new Card(4, 10));
            cards.Add(new Card(4, 11));
            //50.
            cards.Add(new Card(4, 12));
            cards.Add(new Card(4, 13));
            cards.Add(new Card(4, 14));
            #endregion

            //    // Adding each card with a loop.
            //    //for (int i = 1; i < 5; i++)
            //    //{
            //    //    for (int j = 2; j < 15; j++)
            //    //    {
            //    //        cards.Add(new Card(i, j));
            //    //    }
            //    //}

            return cards;
        }

        public static HashSet<int> Shuffle()
        {
            HashSet<int> shuffledNumbers = new HashSet<int>(52);

            while (shuffledNumbers.Count < 52)
            {
                Random random = new Random();
                int number = random.Next(0, 52);
                shuffledNumbers.Add(number);
            }
            return shuffledNumbers;
        }

        #region Implementation with Dictionary and int Array
        //public Dictionary<int, Card> NewDeck()
        //{
        //    Dictionary<int, Card> deck = new Dictionary<int, Card>();
        //    int cardNumber = 0;
        //    for (int i = 1; i < 5; i++)
        //    {
        //        for (int j = 2; j < 15; j++)
        //        {
        //            deck.Add(cardNumber++, new Card(i, j));
        //        }
        //    }
        //    return deck;
        //}

        //public int[] Shuffle()
        //{
        //    HashSet<int> shuffledNumbers = new HashSet<int>(52);

        //    while (shuffledNumbers.Count < 52)
        //    {
        //        Random random = new Random();
        //        int number = random.Next(0, 52);
        //        shuffledNumbers.Add(number);
        //    }
        //    return shuffledNumbers.ToArray();
        //}
        #endregion

        //    public Deck() 
        //{
        //    var cards = new Deck();
        //}

        //public static HashSet<Card> ShuffleCards(List<Card> cards)
        //{
        //    HashSet<Card> shuffledCards = new HashSet<Card>(52);

        //    while (shuffledCards.Count < 52)
        //    {
        //        Random random = new Random();
        //        int number = random.Next(0, 52);
        //        shuffledCards.Add(cards[number]);
        //    }
        //    Console.WriteLine(shuffledCards);
        //    return shuffledCards;
        //}

        //public static List<Card> Cards = new List<Card>
        //{
        //    new Card(1, 2),
        //    new Card(1, 4),
        //    new Card(1, 3),
        //    new Card(1, 5),
        //    new Card(1, 6),
        //    new Card(1, 7),
        //    new Card(1, 8),
        //    new Card(1, 9),
        //    new Card(1, 10),
        //    new Card(1, 11),
        //    new Card(1, 12),
        //    new Card(1, 13),
        //    new Card(1, 14),
        //    new Card(2, 2),
        //    new Card(2, 3),
        //    new Card(2, 4),
        //    new Card(2, 5),
        //    new Card(2, 6),
        //    new Card(2, 7),
        //    new Card(2, 8),
        //    new Card(2, 9),
        //    new Card(2, 10),
        //    new Card(2, 11),
        //    new Card(2, 12),
        //    new Card(2, 13),
        //    new Card(2, 14),
        //    new Card(3, 2),
        //    new Card(3, 3),
        //    new Card(3, 4),
        //    new Card(3, 5),
        //    new Card(3, 6),
        //    new Card(3, 7),
        //    new Card(3, 8),
        //    new Card(3, 9),
        //    new Card(3, 10),
        //    new Card(3, 11),
        //    new Card(3, 12),
        //    new Card(3, 13),
        //    new Card(3, 14),
        //    new Card(4, 2),
        //    new Card(4, 3),
        //    new Card(4, 4),
        //    new Card(4, 5),
        //    new Card(4, 6),
        //    new Card(4, 7),
        //    new Card(4, 8),
        //    new Card(4, 9),
        //    new Card(4, 10),
        //    new Card(4, 11),
        //    new Card(4, 12),
        //    new Card(4, 13),
        //    new Card(4, 14),
        //};

    }
    }
