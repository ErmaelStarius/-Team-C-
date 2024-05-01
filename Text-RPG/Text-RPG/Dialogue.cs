using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class Dialogue
    {
        Images images = new Images();

        public void Chapter_01()
        {
            Dialogue_PlayerText player = new Dialogue_PlayerText();
            Dialogue_SystemText system = new Dialogue_SystemText();
            Dialogue_PrisonerText prisoner = new Dialogue_PrisonerText();

            ConsoleKeyInfo dialogue_001 = images.Main(system._SystemName, system._SystemText, system._SystemOption_01, system._SystemOption_02, system._SystemOption_03);

            prisoner.Question_001(dialogue_001);
            player.Answer_001(dialogue_001);

            ConsoleKeyInfo dialogue_002 = images.Main(prisoner._NPC_Name, prisoner._NPC_text, player._PlayerOption_01, player._PlayerOption_02, player._PlayerOption_03);

            prisoner.Question_002(dialogue_002);
            player.Answer_002(dialogue_002);

        }
    }
}
