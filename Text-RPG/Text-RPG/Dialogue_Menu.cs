﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Dialogue_Menu
    {
       public string _Name = "플레이어";
       
       
        
       public string _MainMenu_Text = "\"행동을 선택하시오.\"";
        
       public string _MainMenu_Choice_01 = "\"대화를 한다.\"";
       public string _MainMenu_Choice_02 = "\"상인 메리골드와 거래한다.\"";
       public string _MainMenu_Choice_03 = "\"로스릭의 높은 성 안으로 들어간다.\"";
     

        public void MainChoice(ConsoleKeyInfo InputKey)
        {
            switch (InputKey.Key)
            {
                case ConsoleKey.Z:

                    break;

                case ConsoleKey.X:

                    break;

                case ConsoleKey.C:

                    break;
            }
        }
    }
}
