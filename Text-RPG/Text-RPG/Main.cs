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
                    battle.BattlePhase(player);
                }
                else if (mainmenu.Key == ConsoleKey.D1 || mainmenu.Key == ConsoleKey.NumPad1)
                {
                    
                }
                else if (mainmenu.Key == ConsoleKey.D2 || mainmenu.Key == ConsoleKey.NumPad2)
                {

                }
                else if (mainmenu.Key == ConsoleKey.D3 || mainmenu.Key == ConsoleKey.NumPad3)
                {

                }
                else if (mainmenu.Key == ConsoleKey.D4 || mainmenu.Key == ConsoleKey.NumPad4)
                {

                }
                else if (mainmenu.Key == ConsoleKey.D5 || mainmenu.Key == ConsoleKey.NumPad5)
                {
                    // 퀘스트(목록/내용)
                    Console.Clear();
                    questManager.QuestMenu();
                }
                else
                {
                    Console.Clear();

                    images.Error();

                    mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Option_01, menu._MainMenu_Option_02, menu._MainMenu_Option_03);

                    ConsoleKeyInfo anyKey = Console.ReadKey(true);

                }
            }

        }
    }
}
