using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Madelinette
{
    public class CheckForEmpty : Game
    {
        public void CheckForEmptySpot()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);

            switch (input.Key)
            {
                case ConsoleKey.D1:
                    {
                        if (BoardSpots[2] == 0)
                        {
                            BoardSpots[0] = 0;
                            BoardSpots[2] = Player;
                            break;
                        }
                        else if (BoardSpots[3] == 0)
                        {
                            BoardSpots[0] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D2:
                    {
                        if (BoardSpots[3] == 0)
                        {
                            BoardSpots[1] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else if (BoardSpots[4] == 0)
                        {
                            BoardSpots[1] = 0;
                            BoardSpots[4] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D3:
                    {
                        if (BoardSpots[0] == 0)
                        {
                            BoardSpots[2] = 0;
                            BoardSpots[0] = Player;
                            break;
                        }
                        else if (BoardSpots[3] == 0)
                        {
                            BoardSpots[2] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else if (BoardSpots[5] == 0)
                        {
                            BoardSpots[2] = 0;
                            BoardSpots[5] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D4:
                    {
                        if (BoardSpots[0] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[0] = Player;
                            break;
                        }
                        else if (BoardSpots[1] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[1] = Player;
                            break;
                        }
                        else if (BoardSpots[2] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[2] = Player;
                            break;
                        }
                        else if (BoardSpots[4] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[4] = Player;
                            break;
                        }
                        else if (BoardSpots[5] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[5] = Player;
                            break;
                        }
                        else if (BoardSpots[6] == 0)
                        {
                            BoardSpots[3] = 0;
                            BoardSpots[6] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D5:
                    {
                        if (BoardSpots[1] == 0)
                        {
                            BoardSpots[4] = 0;
                            BoardSpots[1] = Player;
                            break;
                        }
                        else if (BoardSpots[3] == 0)
                        {
                            BoardSpots[4] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else if (BoardSpots[6] == 0)
                        {
                            BoardSpots[4] = 0;
                            BoardSpots[6] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D6:
                    {
                        if (BoardSpots[2] == 0)
                        {
                            BoardSpots[5] = 0;
                            BoardSpots[2] = Player;
                            break;
                        }
                        else if (BoardSpots[3] == 0)
                        {
                            BoardSpots[5] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else if (BoardSpots[6] == 0)
                        {
                            BoardSpots[5] = 0;
                            BoardSpots[6] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                case ConsoleKey.D7:
                    {
                        if (BoardSpots[3] == 0)
                        {
                            BoardSpots[6] = 0;
                            BoardSpots[3] = Player;
                            break;
                        }
                        else if (BoardSpots[4] == 0)
                        {
                            BoardSpots[6] = 0;
                            BoardSpots[4] = Player;
                            break;
                        }
                        else if (BoardSpots[5] == 0)
                        {
                            BoardSpots[6] = 0;
                            BoardSpots[5] = Player;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Play is not valid, no empty spots.");
                            break;
                        }
                    }
                default:
                    Console.WriteLine("Invalid input, please try again.");
                    break;

            }

            if (Player == 1)
                Player = 2;
            else Player = 1;
        }
    }
}
