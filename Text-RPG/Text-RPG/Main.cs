using System;
using System.Collections.Generic;
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

            ConsoleKeyInfo mainmenu = images.Main(menu.ShowMyName(menu._Name), menu._MainMenu_Text, menu._MainMenu_Choice_01, menu._MainMenu_Choice_02, menu._MainMenu_Choice_03);
        }
    }
}
