using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Intro
    {
        Images images = new Images();

        public void IntroScene()
        {
            images.Intro();

            ConsoleKeyInfo startkey = Console.ReadKey(true);

            do
            {
                // 조건
                if (startkey.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    images.Loading();
                    break;

                }
                else if (startkey.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    images.GameOver();
                    Console.ReadKey(true);
                    break;
                }
                else
                {
                    Console.Clear();
                    images.Error();

                    ConsoleKeyInfo restartkey = Console.ReadKey(true);

                    if (restartkey.Key != null)
                    {
                        Console.Clear();
                        images.Intro();

                        startkey = Console.ReadKey(true);
                    }
                }
            } while (true);

        }


    }

}
