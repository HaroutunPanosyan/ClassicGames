using SimpleGames.Deck;
using System;

namespace Games

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            var newDeck = deck.NewDeck();
            var shuffle = deck.Shuffle();

            foreach (var num in shuffle)
            {
                Console.WriteLine($"{(RankEnum.Rank)newDeck[num].Rank} of {(SuitEnum.Suit)newDeck[num].Suit}");
            }

            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine($"First Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            shuffle.Remove(shuffle.FirstOrDefault());
            Console.WriteLine($"Second Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            shuffle.Remove(shuffle.FirstOrDefault());
            Console.WriteLine($"Third Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            shuffle.Remove(shuffle.FirstOrDefault());
            Console.WriteLine($"Fourth Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            shuffle.Remove(shuffle.FirstOrDefault());
            Console.WriteLine($"Fifth Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            shuffle.Remove(shuffle.FirstOrDefault());
            Console.WriteLine($"Sixth Card is: {(RankEnum.Rank)newDeck[shuffle.FirstOrDefault()].Rank} of {(SuitEnum.Suit)newDeck[shuffle.FirstOrDefault()].Suit} ");
            Console.WriteLine();

        }
    }
}