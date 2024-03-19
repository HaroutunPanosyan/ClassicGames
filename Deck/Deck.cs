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
        
        public static void Reset()
        {
            Console.WriteLine("Card(chooseSuit.Next(1,4), chooseRank.Next(2,15)");
        }

        private List<Card> NewDeck()
        {
            List<Card> cards = new List<Card>
            {
                new Card(1, 2),
                new Card(1, 3),
                new Card(1, 4),
                new Card(1, 5),
                new Card(1, 6),
                new Card(1, 7),
                new Card(1, 8),
                new Card(1, 9),
                new Card(1, 10),
                new Card(1, 12),
                new Card(1, 13),
                new Card(1, 14),
                new Card(2, 2),
                new Card(2, 3),
                new Card(2, 4),
                new Card(2, 5),
                new Card(2, 6),
                new Card(2, 7),
                new Card(2, 8),
                new Card(2, 9),
                new Card(2, 10),
                new Card(2, 11),
                new Card(2, 12),
                new Card(2, 13),
                new Card(2, 14),
                new Card(3, 2),
                new Card(3, 3),
                new Card(3, 4),
                new Card(3, 5),
                new Card(3, 6),
                new Card(3, 7),
                new Card(3, 8),
                new Card(3, 9),
                new Card(3, 10),
                new Card(3, 11),
                new Card(3, 12),
                new Card(3, 13),
                new Card(3, 14),
                new Card(4, 2),
                new Card(4, 3),
                new Card(4, 4),
                new Card(4, 5),
                new Card(4, 6),
                new Card(4, 7),
                new Card(4, 8),
                new Card(4, 9),
                new Card(4, 10),
                new Card(4, 11),
                new Card(4, 12),
                new Card(4, 13),
                new Card(4, 14)
            };

            return cards;
        }

        public HashSet<Card> Shuffle()
        {

            var deck = new Deck();
            var fullDeck = deck.NewDeck();
            HashSet<Card> shuffledCards = new HashSet<Card>();

            while (shuffledCards.Count < 52) 
            {                
                Random random = new Random();
                int number = random.Next(2, 52);           

                if (shuffledCards.Count != 52)
                { 
                    if (!fullDeck.Contains(fullDeck[number]))
                    {
                        number = random.Next(2, 52);
                    }
                    shuffledCards.Add(fullDeck[number]);
                    fullDeck.Remove(fullDeck[number]);
                }
                else
                {
                    break;
                }
            }
            return shuffledCards;
        }

    }
}
