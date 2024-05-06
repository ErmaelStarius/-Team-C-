using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class GameManager
    {
        Images images = new Images();
       public Main main = new Main();

        public void StartGame()
        {
            images.Intro();
            ConsoleKeyInfo startkey = Console.ReadKey(true);

            do
            {
                // 조건
                if (startkey.Key == ConsoleKey.Z)
                {
                    images.Loading();
                    new CreateCharacter().NewCharacter();
                    break;

                }
                else if (startkey.Key == ConsoleKey.X)
                {
                    EndGame();
                }
                else
                {
                    
                    images.Error();
                    
                    images.Intro();

                    startkey = Console.ReadKey(true);
                   
                }
            } while (true);

        }


        public void EndGame()
        {
            images.EndPage();
            ConsoleKeyInfo choice = Console.ReadKey();
            do
            {
                if (choice.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    images.GameOver();
                    Environment.Exit(0);
                    break;
                }
                else if (choice.Key == ConsoleKey.X)
                {
                    Console.Clear();
                    StartGame();
                }
                else
                {
                    images.Error();
                    images.EndPage();
                    choice = Console.ReadKey(true);
                }
            } while (true);

        }
    }
}
