using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    public class QuestGameManager
    {
        public Main main;
        public QuestManager questManager;

        public QuestGameManager()
        {
            main = new Main();
            questManager = new QuestManager();
        }
    }
}
