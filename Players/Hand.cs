using SimpleGames.Deck;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Games.Players
{
    public record Hand(List<Card> Cards, int Points, bool CanPlay);
}
