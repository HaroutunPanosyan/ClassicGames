using SimpleGames.Deck;
using SimpleGames.Players;
using System;
using static SimpleGames.Deck.RankEnum;

namespace Games

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = Deck.NewDeck();
            var shuffledDeck = Deck.Shuffle();
            var dealer = new Dealer();
            var player = new Player();            

            dealer.Shuffle();

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

            
            //Console.WriteLine($"First Card is: {(RankEnum.Rank)deck[shuffledDeck.FirstOrDefault()].Rank} of {(SuitEnum.Suit)deck[shuffledDeck.FirstOrDefault()].Suit} ");
            //player.Hit(shuffledDeck, player);
            //Console.WriteLine($"Second Card is: {(RankEnum.Rank)deck[shuffledDeck.FirstOrDefault()].Rank} of {(SuitEnum.Suit)deck[shuffledDeck.FirstOrDefault()].Suit} ");

            string playerChoice;            

            Console.WriteLine("Players Current Hand:");

            player.Hit(shuffledDeck, player);
            Console.WriteLine($"{(RankEnum.Rank)deck[player.Hand[dealer.currentCard]].Rank} of {(SuitEnum.Suit)deck[player.Hand[dealer.currentCard]].Suit}");
            dealer.currentCard++;
            player.Hit(shuffledDeck, player);
            Console.WriteLine($"{(RankEnum.Rank)deck[player.Hand[dealer.currentCard]].Rank} of {(SuitEnum.Suit)deck[player.Hand[dealer.currentCard]].Suit}");
            dealer.currentCard++;
            while (player.canPlay)
            {
                Console.WriteLine(player.CountPoints(player, deck));

                Console.WriteLine("Options:");                
                Console.WriteLine("1. Hit");
                Console.WriteLine("2. Fold");
                
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
                    default:
                        Console.WriteLine("Not a valid choice.");
                        break;
                }                

            }

            Console.WriteLine($"Player's Hand: {(RankEnum.Rank)deck[player.Hand[0]].Rank} of {(SuitEnum.Suit)deck[player.Hand[0]].Suit}");
            

        } 
    }
}