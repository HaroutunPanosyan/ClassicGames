using Games.Players;
using SimpleGames.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleGames.Players.Player;

namespace SimpleGames.Players
{
    class Dealer
    {
        private List<Card> _cards = Deck.Deck.NewDeck();
        private HashSet<int> _deck = Deck.Deck.Shuffle();  

        public Card Deal()
        {
            List<int> shuffledCards = _deck.ToList();
            _deck.Remove(shuffledCards.Last());
            return new Card(_cards[_deck.Last()].Suit, _cards[_deck.Last()].Rank);            
        }
    }
}
