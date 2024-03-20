using SimpleGames.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames.Players
{
    class Dealer : IActions
    {
        public List<int> Hand = new List<int>();
        public bool hasFolded = false;
        public int currentCard { get; set; }

        public bool Bet()
        {
            throw new NotImplementedException();
        }

        public bool Call()
        {
            throw new NotImplementedException();
        }

        public bool Fold()
        {
            return hasFolded = true;
        }

        public void Hit(HashSet<int> shuffledDeck, Player player)
        {
            int i = 0;
            Deal(shuffledDeck, player, i++);
        }

        public HashSet<int> Shuffle()
        {
            var deck = Deck.Deck.NewDeck();
            return Deck.Deck.Shuffle();
        }

        public static Player Deal(HashSet<int> shuffledDeck, Player player, int cardNumber)
        {            
            var sD = shuffledDeck.ToArray();
            player.Hand.Add(sD[cardNumber]);
            cardNumber++; 
            shuffledDeck.Remove(shuffledDeck.FirstOrDefault());

            return player;
        }
    }
}
