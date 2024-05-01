using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Dialogue_PlayerText
    {
        public string _Player_Name = "플레이어";

        public string _PlayerOption_01;
        public string _PlayerOption_02;
        public string _PlayerOption_03;

        public void Answer_001(ConsoleKeyInfo InputKey)
        {
            switch (InputKey.Key)
            {
                case ConsoleKey.Z:
                    _PlayerOption_01 = "\"소리가 들려오는 쪽으로 향한다.\"";
                    _PlayerOption_02 = "\"이게 무슨 소리지..?\""; ;
                    _PlayerOption_03 = "\"무시한다.\""; ;
                    break;
                case ConsoleKey.X:
                    _PlayerOption_01 = "\"소리가 들려오는 쪽으로 향한다.\"";
                    _PlayerOption_02 = "\"이게 무슨 소리지..?\""; ;
                    _PlayerOption_03 = "\"무시한다.\""; ;
                    break;
                case ConsoleKey.C:
                    _PlayerOption_01 = "\"소리가 들려오는 쪽으로 향한다.\"";
                    _PlayerOption_02 = "\"이게 무슨 소리지..?\""; ;
                    _PlayerOption_03 = "\"무시한다.\""; ;
                    ;
                    break;
            }
        }

        public void Answer_002(ConsoleKeyInfo InputKey)
        {
            switch (InputKey.Key)
            {
                case ConsoleKey.Z:
                    _PlayerOption_01 = "\"\"";
                    _PlayerOption_02 = "\"\""; ;
                    _PlayerOption_03 = "\"\""; ;
                    break;
                case ConsoleKey.X:
                    _PlayerOption_01 = "\"소리가 들려오는 쪽으로 향한다.\"";
                    _PlayerOption_02 = "\"이게 무슨 소리지..?\""; ;
                    _PlayerOption_03 = "\"무시한다.\""; ;
                    break;
                case ConsoleKey.C:
                    _PlayerOption_01 = "\"소리가 들려오는 쪽으로 향한다.\"";
                    _PlayerOption_02 = "\"이게 무슨 소리지..?\""; ;
                    _PlayerOption_03 = "\"무시한다.\""; ;
                    ;
                    break;
            }
        }




    }
}
