using SimpleGames.Deck;
using SimpleGames.Players;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames.CoreLogic
{
    public class BlackJack
    {
        public int points = 0;

        public BlackJack() 
        {
            #region CheckCards

            //foreach (var num in shuffledDeck)
            //{
            //    // Method 1: Using List and HashSet.
            //    Console.WriteLine($"{(RankEnum.Rank)deck[num].Rank} of {(SuitEnum.Suit)deck[num].Suit}");

            //    /*
            //       Using Method 2: Dictionary and int Array:

            //       if (deck.ContainsKey(shuffle[item]))
            //       {
            //           Console.WriteLine($"{(RankEnum.Rank)deck.GetValueOrDefault(shuffle[item]).Rank} of {(SuitEnum.Suit)deck.GetValueOrDefault(shuffle[item]).Suit} is card {i++}");
            //       }
            //       deck.Remove(shuffle.FirstOrDefault()); 
            //    */
            //}

            #endregion

            var deck = Deck.Deck.NewDeck();
            var shuffledDeck = Deck.Deck.Shuffle();
            var dealer = new Dealer();
            var player = new Player();
            dealer.Shuffle();
            string playerChoice;

            #region GameStart
            Console.WriteLine("Players Current Hand:");
            player.Hit(shuffledDeck, player);
            Console.WriteLine($"{(RankEnum.Rank)deck[player.Hand[dealer.currentCard]].Rank} of {(SuitEnum.Suit)deck[player.Hand[dealer.currentCard]].Suit}");
            dealer.currentCard++;
            player.Hit(shuffledDeck, player);
            Console.WriteLine($"{(RankEnum.Rank)deck[player.Hand[dealer.currentCard]].Rank} of {(SuitEnum.Suit)deck[player.Hand[dealer.currentCard]].Suit}");
            dealer.currentCard++;
            #endregion

            #region CoreLogic
            while (player.canPlay)
            {
                var totalPoints = AddPoints(player, deck);
                Console.WriteLine(totalPoints);

                if (totalPoints >= 22)
                {
                    Console.WriteLine("Bust. You've gone way over.");
                    player.canPlay = false;
                    break;
                }

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
                        player.Hit(shuffledDeck, player);
                        Console.WriteLine($"{(RankEnum.Rank)deck[player.Hand[dealer.currentCard]].Rank} of {(SuitEnum.Suit)deck[player.Hand[dealer.currentCard]].Suit}");
                        dealer.currentCard++;

                        break;
                    case "2":
                        player.canPlay = false;
                        break;
                    case "3":
                        player.Split(player, deck);
                        break;
                    case "4":
                        BlackJack.PlayBlackJack();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }

            }
            #endregion

            Console.WriteLine($"Player's Hand: {(RankEnum.Rank)deck[player.Hand[0]].Rank} of {(SuitEnum.Suit)deck[player.Hand[0]].Suit}");
        }

        public static BlackJack PlayBlackJack()
        {
            BlackJack blackJack = new BlackJack();
            return blackJack;
        }

        public int AddPoints(Player player, List<Card> card)
        {
            List<int> addPoints = new List<int>();
            var cards = GetRank(player, card);

            foreach (int item in cards)
            {
                if (PointValue(item).ContainsKey(item))
                {
                    addPoints.Add(PointValue(item).GetValueOrDefault(item));
                }
            }
            points = addPoints.Sum();
            return points;
        }

        public List<int> GetRank(Player player, List<Card> card)
        {
            var cards = GetPlayerCard(player);
            List<int> rank = new List<int>();

            foreach (var item in cards)
            {
                rank.Add(card[item].Rank);
            }

            return rank;
        }

        public HashSet<int> GetPlayerCard(Player player)
        {
            HashSet<int> cardNumber = new HashSet<int>();

            for (int i = 0; i < player.Hand.Count; i++)
            {
                cardNumber.Add(player.Hand[i]);
            }

            return cardNumber;
        }


        public static Dictionary<int, int> PointValue(int key)
        {
            Dictionary<int, int> points = new Dictionary<int, int>();

            points.Add(2, 2);
            points.Add(3, 3);
            points.Add(4, 4);
            points.Add(5, 5);
            points.Add(6, 6);
            points.Add(7, 7);
            points.Add(8, 8);
            points.Add(9, 9);
            points.Add(10, 10);
            points.Add(11, 10);
            points.Add(12, 10);
            points.Add(13, 10);
            points.Add(14, 11);

            return points;
        }
    }
}
