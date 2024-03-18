using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGames.Players
{
    public interface IActions
    {
        void Call(); // Also known as Stay in some games.
        void Fold();
        void Bet(); // Also known as Hit in some games.
    }
}
