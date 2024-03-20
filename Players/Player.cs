using SimpleGames.CoreLogic;
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

        public List<List<int>> Split(Player player, List<Card> card)
        {
            List<List<int>> Hands = new List<List<int>>();

            var card1 = card[player.Hand[0]].Rank;
            var card2 = card[player.Hand[1]].Rank;
            var Hand1 = player.Hand;
            var Hand2 = player.Hand;
            int card1PointValue = BlackJack.PointValue(card1).GetValueOrDefault(card1);
            int card2PointValue = BlackJack.PointValue(card2).GetValueOrDefault(card2);

            if (card1PointValue == card2PointValue)
            {
                Console.WriteLine("Cards have been split.");
                Hand1.Add(player.Hand[0]);
                Hand2.Add(player.Hand[1]);
                Hands.Add(Hand1);
                Hands.Add(Hand2);

                Console.WriteLine($"First Hand has: {(Rank)card[Hand1[0]].Rank} of {(Rank)card[Hand1[0]].Suit} ");
                Console.WriteLine($"Second Hand has: {(Rank)card[Hand2[0]].Rank} of {(Rank)card[Hand2[0]].Suit}");

                return Hands;
            }
            else
            {
                Console.WriteLine("Cannot split cards with non-matching point values.");
                Hand1.Add(player.Hand[0]);
                Hand1.Add(player.Hand[1]);
                Hands.Add(Hand1);
                return Hands;
            }
        }

    }
}
