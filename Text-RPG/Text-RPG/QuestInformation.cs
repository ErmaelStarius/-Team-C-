using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

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

        public MonsterInfo(string monsterName, int monsterHp, int monsterAtk)
        {
            MonsterName = monsterName;
            MonsterHp = monsterHp;
            MonsterAtk = monsterAtk;
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

internal class Player
{
    public string Name { get; set; }
    public string Job { get; set; }
    public int Level { get; set; }
    public int Atk { get; set; }
    public int Def { get; set; }
    public int Hp { get; set; }
    public int Mp { get; set; }
    public int Gold { get; set; }
    public int Exp { get; set; }

    public Player(string name, string job, int level, int atk, int def, int hp, int mp, int gold, int exp)
    {
        Name = name;
        Job = job;
        Level = level;
        Atk = atk;
        Def = def;
        Hp = hp;
        Mp = mp;
        Gold = gold;
        Exp = exp;
    }
}

//임시 리스트
//public class GameManager
//{
//    private Player player;
//    private List<ItemInfo> inventory;

//    private List<ItemInfo> storeInventory;


//    public GameManager()
//    {
//        InventoryInfo();
//    }

//    private void InventoryInfo()
//    {
//        player = new Player("사람", "전사", 1, 10, 5, 100, 30, 1500, 0);

//        inventory = new List<ItemInfo>();

//        storeInventory = new List<ItemInfo>();
//        storeInventory.Add(new ItemInfo("무쇠갑옷", 0, 5, 0, 0, 800));
//        storeInventory.Add(new ItemInfo("낡은 검", 2, 0, 0, 0, 200));
//        storeInventory.Add(new ItemInfo("골든 헬름", 0, 9, 0, 0, 1200));
//    }
//}

//internal class GameData
//{
//    public List<ItemInfo> items = new List<ItemInfo>()
//        {
//           new ItemInfo("낡은 검", 3, 0, 0, 0, 200),
//           new ItemInfo("낡은 방패", 0, 2, 1, 0, 100),
//           new ItemInfo("롱 소드", 8, 0, 0, 0, 500),
//           new ItemInfo("숏 보우", 13, 0, 0, 0, 800),
//           new ItemInfo("롱 보우", 18, 0, 0, 0, 1100),
//           new ItemInfo("마법 지팡이", 10, 0, 0, 10, 800),
//           new ItemInfo("영혼의 지팡이", 15, 0, 0, 15, 1200)
//        };

//    // 몬스터 목록
//    public List<MonsterInfo> monsters = new List<MonsterInfo>()
//        {
//           new MonsterInfo("늑대", 100, 6),
//           new MonsterInfo("고블린", 120, 8),
//           new MonsterInfo("사무라이", 200, 15),
//           new MonsterInfo("유령", 150, 10),
//           new MonsterInfo("오크", 250, 20),
//           new MonsterInfo("드래곤", 1000, 100)
//        };
//}

