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
        QuestManager questManager = new QuestManager();
        Dialogue dialogue = new Dialogue();
        Battle battle = new Battle();

        public void MainMenu(Player player)
        {
            Console.Clear();
            Dialogue_Menu menu = new Dialogue_Menu();

            ConsoleKeyInfo mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Option_01, menu._MainMenu_Option_02, menu._MainMenu_Option_03);

            while (true)
            {
                if (mainmenu.Key == ConsoleKey.Z)
                {
                    Console.Clear();
                    dialogue.Chapter_01();
                }
                else if (mainmenu.Key == ConsoleKey.X)
                {

                }
                else if (mainmenu.Key == ConsoleKey.C)
                {
                    Console.Clear();
                    battle.BattlePhase();
                }
                else if (mainmenu.Key == ConsoleKey.D5 || mainmenu.Key == ConsoleKey.NumPad5)
                {
                    // 퀘스트(목록/내용)
                    Console.Clear();
                    questManager.QuestMenu();
                }
                else if (mainmenu.Key == ConsoleKey.D1)
                {
                    
                }
                else
                {
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
