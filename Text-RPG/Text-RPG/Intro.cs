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
                    new CreateCharacter().NewCharacter();
                    break;

                }
                else if (startkey.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("           게임을 종료 하시겠습니까?          \n");
                    Console.WriteLine("               1.예, 2.아니오                 \n");
                    Console.WriteLine("**********************************************");
                    Console.Write(">> ");
                    int choice = ConsoleUtility.PromptChoice(1,2);
                    switch(choice)
                    {
                        case 1:
                            Console.Clear();
                            images.GameOver();
                            break;
                        case 2:
                            Console.Clear();
                            IntroScene();
                            break;
                    }
                    return;
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
