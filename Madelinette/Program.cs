using System;
using System.Threading;
using System.Collections.Concurrent;
using System.Collections.Generic;


namespace Madelinette
{
    class Program
    {
        // Canvas Size
        private const int XMax = 10;
        private const int YMax = 10;

        private bool running;
        private BlockingCollection<ConsoleKey> input;
        private Thread inputThread;
        private DoubleBuffer2D<char> buffer2D;
        private ICollection<GameObject> gameObjects;
        
        private static void Main(string[]args)
        {
            Program p = new Program();
            p.SetupScene();
            p.GameLoop();
            p.Finish();

        }

        private Program()
        {
            input = new BlockingCollection<ConsoleKey>();
            inputThread = new Thread(ReadKeys);
            gameObjects = new List<GameObject>();
            buffer2D = new DoubleBuffer2D<char>(XMax,YMax);
            //Console.CursorVisible = false;
        }
        private void SetupScene()
        {
            GameObject gameObject = new Player('X', YMax,XMax);
            gameObject.Position = new int[] { 0, 0 };
            gameObjects.Add(gameObject);
        }
        private void GameLoop()
        {
            int msPerFrame = 30;
            Console.Clear();
            running = true;
            inputThread.Start();

            while(running)
            {
                int start = DateTime.Now.Millisecond;
                ProcessInput();
                foreach(GameObject gObject in gameObjects)
                {
                    gObject.Update();
                }
                Render();
                Console.WriteLine(start);
                Console.WriteLine(msPerFrame);
                Console.WriteLine(DateTime.Now.Millisecond);
                Thread.Sleep(start + msPerFrame - DateTime.Now.Millisecond);
            }
        }

        private void ProcessInput()
        {
            ConsoleKey key;
            if(input.TryTake(out key))
            {
                switch(key)
                {
                    case ConsoleKey.A:
                        foreach (GameObject gObject in gameObjects)
                        {
                            if (gObject.Position[0] > 0)
                                gObject.Position[0]--;
                        }
                        break;
                    case ConsoleKey.W:
                        foreach (GameObject gObject in gameObjects)
                        {
                            if (gObject.Position[1] > 0)
                                gObject.Position[1]--;
                        }
                        break;
                    case ConsoleKey.D:
                        foreach (GameObject gObject in gameObjects)
                        {
                            if (gObject.Position[0] < XMax - 1)
                                gObject.Position[0]++;
                        }
                        break;
                    case ConsoleKey.S:
                        foreach (GameObject gObject in gameObjects)
                        {
                            if(gObject.Position[1] < YMax - 1)
                                gObject.Position[1]++;
                        }
                        break;
                    case ConsoleKey.Escape:
                        running = false;
                        break;
                }
            }
            else
            {
                Console.Write("_no_");
            }
        }
        
        private void Render()
        {
            foreach(GameObject gObject in gameObjects)
            {
                int[] pos = gObject.Position;
                buffer2D[pos[0], pos[1]] = gObject.Sprite;
            }
            buffer2D.Swap();
            Console.SetCursorPosition(0, 0);
            for(int y = 0; y < YMax; y++)
            {
                for (int x = 0; x < XMax; x++)
                {
                    char sprite = buffer2D[x, y];
                    if (sprite != default) Console.Write(sprite);
                    else Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
        private void Finish()
        {
            Console.CursorVisible = true;
            inputThread.Join();
        }
        private void ReadKeys()
        {
            ConsoleKey ck;
            do
            {
                ck = Console.ReadKey(true).Key;
                input.Add(ck);
            } while (ck != ConsoleKey.Escape);
        }
    }
}
