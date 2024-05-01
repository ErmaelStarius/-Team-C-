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
            Dialogue_Menu menu = new Dialogue_Menu();

            ConsoleKeyInfo mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Choice_01, menu._MainMenu_Choice_02, menu._MainMenu_Choice_03);

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

                }
                else
                {
                    Console.Clear();

                    images.Error();

                    ConsoleKeyInfo anyKey = Console.ReadKey(true);

                    if (anyKey.Key != null)
                    {
                        Console.Clear();

                        mainmenu = images.Main(menu._Name, menu._MainMenu_Text, menu._MainMenu_Choice_01, menu._MainMenu_Choice_02, menu._MainMenu_Choice_03);
                    }

                }
            }

        }
    }
}
