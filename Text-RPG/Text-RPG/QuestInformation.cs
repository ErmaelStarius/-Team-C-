using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Text_RPG;


namespace Text_RPG
{
    internal class QuestInformation
    {
        public static int MenuChoice(int min, int max) //번호선택
        {
            while (true)
            {
                Console.Write(" 원하시는 번호를 입력해주세요 >> ");
                if (int.TryParse(Console.ReadLine(), out int choiceQuest) && choiceQuest >= min && choiceQuest <= max)
                {
                    return choiceQuest;
                }
                Console.WriteLine();
                Console.WriteLine(" 잘못된 입력입니다. 번호로 입력 해주세요.");
                Console.WriteLine();
            }
        }

}
    internal class MonsterInfo
    {
        public string MonsterName { get; set; }
        public int MonsterHp { get; set; }
        public int MonsterAtk { get; set;}
        public int MonsterDef { get; set; }

        public MonsterInfo(string monsterName, int monsterHp, int monsterAtk, int monsterDef)
        {
            MonsterName = monsterName;
            MonsterHp = monsterHp;
            MonsterAtk = monsterAtk;
            MonsterDef = monsterDef;
        }
    }

    internal class ItemInfo
    {
        public string ItemName { get; set; }
        public int ItemAtk { get; set; }
        public int ItemDef { get; set; }
        public int ItemHp { get; set; }
        public int ItemPrice { get; set; }
        public int ItemMp { get; set; }


    public ItemInfo(string name, int atk, int def, int hp, int mp, int price)
        {
            ItemName = name;
            ItemAtk = atk;
            ItemDef = def;
            ItemHp = hp;
            ItemMp = mp;
            ItemPrice = price;
    }

}
    


    internal class QuestDifficultyReward
    {
        public int QuestGold { get; set; }
        public int QuestExp { get; set; }

    public QuestDifficultyReward(int questGold, int questExp)
        {
            QuestGold = questGold;
            QuestExp = questExp;
        }

}

}