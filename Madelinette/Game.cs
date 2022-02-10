using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madelinette
{
    public class Game
    {
        // 0 = Empty, 1 = Player 1 Piece, 2 = Player 2 Piece
        public int[] BoardSpots = new int[7] { 1, 2, 2, 0, 1, 1, 2};

        public int Player = 1;
    }
}
