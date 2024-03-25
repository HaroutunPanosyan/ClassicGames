using Games.Players;
using SimpleGames.CoreLogic;
using SimpleGames.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static SimpleGames.Deck.RankEnum;
using static SimpleGames.Players.Player;

namespace SimpleGames.Players
{
    public class Player
    {
        private Dealer _dealer = new Dealer();        

        internal List<Hand> Hands { get; set; }

        //public Player[] PlayerCount { get; set; }
        List<int> Cards { get; set; }
        int Points { get; set; }
        bool CanPlay { get; set; }


        //public Player(List<Hand> hands)
        //{
        //    Hands = hands;
        //}

        public Player(List<Hand> hands)
        {
            Hands = hands;            
        }

        public void Hit(List<Hand> hands, int handIndex)
        {
            hands[handIndex].Cards.Add(_dealer.Deal());             
        }

        public int Split(int handIndex)
        {
            return 0;
        }

        //private int GetPoints(List<Hand> hands, int handIndex)
        //{
        //    int points = 0;
        //    foreach (var card in hands[handIndex].Cards)
        //    {
        //        points += card;
        //    }
        //    return points;
        //}
    }
}
