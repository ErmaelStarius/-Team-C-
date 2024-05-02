using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Dialogue_PrisonerText
    {

        public string _NPC_Name = "죄수번호 1504";

        public string _NPC_text;

        public void Question_001(ConsoleKeyInfo InputKey)
        {
            switch (InputKey.Key)
            {
                case ConsoleKey.Z:
                    _NPC_text = "\"이봐, 여기야! 여기...!\"";
                    break;
                case ConsoleKey.X:
                    _NPC_text = "\"이봐, 여기야! 여기...!\"";
                    break;
                case ConsoleKey.C:
                    _NPC_text = "\"이봐, 여기야! 여기...!\"";
                    break;
            }
        }

        public void Question_002(ConsoleKeyInfo InputKey)
        {
            switch (InputKey.Key)
            {
                case ConsoleKey.Z:
                    _NPC_text = "\"그래! 이쪽이야!\"";
                    break;
                case ConsoleKey.X:
                    _NPC_text = "\"어서, 날 여기서 꺼내 줘!\"";
                    break;
                case ConsoleKey.C:
                    _NPC_text = "\"이봐! 거기 너!\"";
                    break;
            }
        }
    }
}
