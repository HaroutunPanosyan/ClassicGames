using SimpleGames.Deck;

namespace Games

{
    internal class Program
    {
        static void Main(string[] args)
        {
            var deck = new Deck();
            var newDeck = deck.Shuffle();

            foreach (var num in newDeck)
            {
                Console.WriteLine($"{(RankEnum.Rank)(num.Rank)} of {(SuitEnum.Suit)num.Suit}");
            }

        }
    }
}