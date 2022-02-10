using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madelinette.Common
{
    internal class CheckForWin : Game
    {
        public bool CheckForWinCondition()
        {
            if (BoardSpots[0] == Player && BoardSpots[2] == 0) { return false; }
            else if (BoardSpots[0] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[1] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[0] == Player && BoardSpots[4] == 0) { return false; }
            else if (BoardSpots[2] == Player && BoardSpots[0] == 0) { return false; }
            else if (BoardSpots[2] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[2] == Player && BoardSpots[5] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[0] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[1] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[2] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[4] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[5] == 0) { return false; }
            else if (BoardSpots[3] == Player && BoardSpots[6] == 0) { return false; }
            else if (BoardSpots[4] == Player && BoardSpots[1] == 0) { return false; }
            else if (BoardSpots[4] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[4] == Player && BoardSpots[6] == 0) { return false; }
            else if (BoardSpots[5] == Player && BoardSpots[2] == 0) { return false; }
            else if (BoardSpots[5] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[5] == Player && BoardSpots[6] == 0) { return false; }
            else if (BoardSpots[6] == Player && BoardSpots[3] == 0) { return false; }
            else if (BoardSpots[6] == Player && BoardSpots[4] == 0) { return false; }
            else if (BoardSpots[6] == Player && BoardSpots[5] == 0) { return false; }
            else if (Player == 1)
            {
                Console.WriteLine("Player 2 won.");
                return true;
            }
            else if (Player == 2)
            {
                Console.WriteLine("Player 1 won.");
                return true;
            }
            else return false;
        }
    }
}
