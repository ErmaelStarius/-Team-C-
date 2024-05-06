using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Text_RPG.QuestManager;

namespace Text_RPG
{
    public class Main
    {
        
        Images images = new Images();

        public void MainMenu(Player player, QuestGameManager gameManager)
        {
            Console.Clear();
            Dialogue_Menu menu = new Dialogue_Menu();
            ConsoleKeyInfo mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Option_01, menu._MainMenu_Option_02, menu._MainMenu_Option_03);

            while (true)
            {
                if (mainmenu.Key == ConsoleKey.Z)
                {

                }
                else if (mainmenu.Key == ConsoleKey.X)
                {

                }
                else if (mainmenu.Key == ConsoleKey.C)
                {
                    MainMenu(player, gameManager);
                }
                else if (mainmenu.Key == ConsoleKey.D1 || mainmenu.Key == ConsoleKey.NumPad1)
                {
                    new Status().StatusMenu(player, gameManager);
                }
                else if (mainmenu.Key == ConsoleKey.D5 || mainmenu.Key == ConsoleKey.NumPad5)
                {
                    gameManager.questManager.QuestMenu(player, gameManager);
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
