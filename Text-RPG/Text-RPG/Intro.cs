﻿using System;
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
                // 새로하기 > 로딩화면
                if (startkey.Key == ConsoleKey.Z)
                {
                    images.Loading();
                    break;

                }
                // 이어하기
                else if (startkey.Key == ConsoleKey.X)
                {

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
