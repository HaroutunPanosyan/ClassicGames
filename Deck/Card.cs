using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames.Deck
{
    public class Card
    {
        public int Rank { get; set; }

        public int Suit { get; set; }

        public Card() { }
        public Card(int suit, int rank)
        {
            Rank = rank;
            Suit = suit;
        }       

        public void FaceUp()
        {

        }

        public void FaceDown()
        {

        }
    }
}
