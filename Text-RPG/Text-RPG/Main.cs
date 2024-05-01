using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Main
    {
        Images images = new Images();

        public void MainMenu()
        {
            Dialogue dialogue = new Dialogue();
            Dialogue_Menu menu = new Dialogue_Menu();

            ConsoleKeyInfo mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Option_01, menu._MainMenu_Option_02, menu._MainMenu_Option_03);

            while (true)
            {
                if (mainmenu.Key == ConsoleKey.Z)
                {
                    // 대화(퀘스트)
                    dialogue.Chapter_01();
                }
                else if (mainmenu.Key == ConsoleKey.X)
                {
                    // 상점(판매/구매)
                    
                }
                else if (mainmenu.Key == ConsoleKey.C)
                {
                    // 전투
                    
                }
                else
                {
                    // 에러
                    Console.Clear();

                    images.Error();

                    ConsoleKeyInfo anyKey = Console.ReadKey(true);

                    if (anyKey.Key != null)
                    {
                        Console.Clear();

                        mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Option_01, menu._MainMenu_Option_02, menu._MainMenu_Option_03);
                    }

                }
            }

        }
    }
}
