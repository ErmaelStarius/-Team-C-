using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Title
    {
        Images images = new Images();
        Intro intro = new Intro();

        public void TitleScene()
        {
            images.Title();

            ConsoleKeyInfo startkey = Console.ReadKey(true);

            do
            {
                // 게임시작 > 로딩화면
                if (startkey.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    intro.IntroScene();
                    break;

                }
                // 게임종료
                else if (startkey.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    images.GameOver();
                    Console.ReadKey(true);
                    Environment.Exit(0);
                    break;
                }
                // 에러화면
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
