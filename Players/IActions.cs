using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames.Players
{
    public interface IActions
    {
        bool Call(); // Also known as Stay in some games.
        bool Fold();
        bool Bet(); 
        void Hit(HashSet<int> shuffledDeck, Player player);
    }
}
