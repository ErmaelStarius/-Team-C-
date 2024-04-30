using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Dialogue_Menu
    {
       public string _Name = "플레어";
       
       
        
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

        public string ShowMyName(string _name)
        {
            string Current_Name = $"{_name}";

            int space = 26 - Current_Name.Length;

            switch (space)
            {
                case 0:
                    Current_Name = $"{_name}";
                    break;
                case 1:
                    Current_Name = $"{_name}" + " ";
                    break;
                case 2:
                    Current_Name = " " + $"{_name}" + " ";
                    break;
                case 3:
                    Current_Name = " " + $"{_name}" + "  ";
                    break;
                case 4:
                    Current_Name = "  " + $"{_name}" + "  ";
                    break;
                case 5:
                    Current_Name = "  " + $"{_name}" + "   ";
                    break;
                case 6:
                    Current_Name = "   " + $"{_name}" + "   ";
                    break;
                case 7:
                    Current_Name = "   " + $"{_name}" + "    ";
                    break;
                case 8:
                    Current_Name = "    " + $"{_name}" + "    ";
                    break;
                case 9:
                    Current_Name = "    " + $"{_name}" + "     ";
                    break;
                case 10:
                    Current_Name = "     " + $"{_name}" + "     ";
                    break;
                case 11:
                    Current_Name = "     " + $"{_name}" + "      ";
                    break;
                case 12:
                    Current_Name = "      " + $"{_name}" + "      ";
                    break;
                case 13:
                    Current_Name = "      " + $"{_name}" + "       ";
                    break;
                case 14:
                    Current_Name = "       " + $"{_name}" + "       ";
                    break;
                case 15:
                    Current_Name = "       " + $"{_name}" + "        ";
                    break;
                case 16:
                    Current_Name = "        " + $"{_name}" + "        ";
                    break;
                case 17:
                    Current_Name = "        " + $"{_name}" + "         ";
                    break;
                case 18:
                    Current_Name = "         " + $"{_name}" + "         ";
                    break;
                case 19:
                    Current_Name = "         " + $"{_name}" + "          ";
                    break;
                case 20:
                    Current_Name = "          " + $"{_name}" + "          ";
                    break;
                case 21:
                    Current_Name = "          " + $"{_name}" + "            ";
                    break;
                case 22:
                    Current_Name = "           " + $"{_name}" + "            ";
                    break;
                case 23:
                    Current_Name = "           " + $"{_name}" + "             ";
                    break;
                case 24:
                    Current_Name = "            " + $"{_name}" + "             ";
                    break;
                case 25:
                    Current_Name = "            " + $"{_name}" + "              ";
                    break;
            }
            return Current_Name;
        }
    }
}
