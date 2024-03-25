using Games.Players;
using SimpleGames.Deck;
using SimpleGames.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using static SimpleGames.Players.Player;

namespace SimpleGames.CoreLogic
{
    public class BlackJack
    {
        private static readonly Dictionary<int, int> Points = new Dictionary<int, int>
        {
            { 2, 2 },
            { 3, 3 },
            { 4, 4 },
            { 5, 5 },
            { 6, 6 },
            { 7, 7 },
            { 8, 8 },
            { 9, 9 },
            { 10, 10 },
            { 11, 10 },
            { 12, 10 },
            { 13, 10 },
            { 14, 11 },
        };

        public BlackJack() 
        {
            List<Player> players = new List<Player>();
            List<Card> p1cards = new List<Card>();
            List<Card> p2cards = new List<Card>();
            int p1points = 0; 
            int p2points = 0; 
            bool p1canPlay = true;
            bool p2canPlay = true;
            List<Hand> p1Hands = new List<Hand>(); 
            List<Hand> p2Hands = new List<Hand>(); 
            p1Hands.Add(new Hand(p1cards, p1points, p1canPlay));
            p2Hands.Add(new Hand(p2cards, p2points, p2canPlay));
            Player player = new Player(p1Hands);
            Player player2 = new Player(p2Hands);
            players.Add(player);
            players.Add(player2);
            int plCount = 0;
           
            foreach (var pl in players)
            {
                Console.WriteLine($"For player: {++plCount}");
                Console.WriteLine();

                pl.Hit(pl.Hands, 0);
                Console.WriteLine($"{(RankEnum.Rank)(int)pl.Hands[0].Cards.Last().Rank} of {(SuitEnum.Suit)(int)pl.Hands[0].Cards.Last().Suit}.");
                pl.Hit(pl.Hands, 0);
                Console.WriteLine($"{(RankEnum.Rank)(int)pl.Hands[0].Cards.Last().Rank} of {(SuitEnum.Suit)(int)pl.Hands[0].Cards.Last().Suit}.");

                Console.WriteLine();
            }            

            string playerChoice;

            while (players.Any(hands => hands.Hands.Any(s => s.CanPlay)))
            {
                
                Console.WriteLine("Options:");
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Fold");
                Console.WriteLine("3. Split");
                Console.WriteLine("4. New Hand");

                Console.WriteLine();
                playerChoice = Console.ReadLine();
                switch (playerChoice)
                {
                    case "1":
                        player.Hit(p1Hands, 0);
                        Console.WriteLine($"{(RankEnum.Rank)(int)player.Hands[0].Cards.Last().Rank} of {(SuitEnum.Suit)(int)player.Hands[0].Cards.Last().Suit}.");
                        break;
                    //case "2":
                    //    player.canPlay = false;
                    //    break;
                    //case "3":
                    //    player.Split(player, deck);
                    //    break;
                    case "4":
                        BlackJack.PlayBlackJack();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }

            }


        }

        public static BlackJack PlayBlackJack()
        {
            BlackJack blackJack = new BlackJack();
            return blackJack;
        }

        //public int AddPoints(Player player, List<Card> card)
        //{
        //    int sum = 0;
        //    var ranks = GetRanks(player, card);

        //    foreach (int rank in ranks)
        //    {
        //        if (Points.ContainsKey(rank))
        //        {
        //            sum += Points[rank];
        //        }
        //    }
        //    return sum;
        //}

        //public List<int> GetRanks(Player player, List<Card> card)
        //{
        //    var cards = GetPlayerCard(player);
        //    List<int> rank = new List<int>();

        //    foreach (var item in cards)
        //    {
        //        rank.Add(card[item].Rank);
        //    }

        //    return rank;
        //}

        //public HashSet<int> GetPlayerCard(Player player)
        //{
        //    HashSet<int> cardNumber = new HashSet<int>();
        //    foreach (var card in player.Hands[0].Cards)
        //    {
        //        cardNumber.Add(card); 
        //    }
        //    return cardNumber;
        //}
    }
}
