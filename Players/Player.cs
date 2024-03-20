using SimpleGames.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SimpleGames.Deck.RankEnum;

namespace SimpleGames.Players
{
    public class Player : IActions
    {
        public List<int> Hand = new List<int>();
        public bool hasFolded = false;
        public bool canPlay = true;
        public int points = 0;

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
            Dealer.Deal(shuffledDeck, player, i++);
        }
        public int CountPoints(Player player, List<Card> card)
        {
            var hand = player.Hand;
            List<int> ints = new List<int>();
            
            foreach (var item in hand)
            {                
                var pointsForCurrentCard = GetPoints(card[item]);
                ints.Add(pointsForCurrentCard);
            }
            points = ints.Sum(x => x);
            return points;
        }

        public int GetPoints(Card card)
        {
            var rank = (int)(RankEnum.Points)card.Rank;    
            return rank;
        }

    }
}
