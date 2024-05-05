using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    public class GameManager
    {
        public Main main;
        public QuestManager questManager;

        public GameManager()
        {
            main = new Main();
            questManager = new QuestManager();
        }
    }
}
