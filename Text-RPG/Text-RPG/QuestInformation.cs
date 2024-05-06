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
        public bool IsEquipped { get; private set; }
        public bool IsPurchased { get; private set; }


    public ItemInfo(string name, int atk, int def, int hp, int mp, int price, bool isEquipped = false, bool isPurchased = false)
        {
            ItemName = name;
            ItemAtk = atk;
            ItemDef = def;
            ItemHp = hp;
            ItemMp = mp;
            ItemPrice = price;
            IsEquipped = isEquipped;
            IsPurchased = isPurchased;
    }

    internal void PrintItemStatDescription(bool withNumber = false, int idx = 0)
    {
        Console.Write("- ");
        if (withNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write($"{idx} ");
            Console.ResetColor();
        }
        if (IsEquipped)
        {
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("E");
            Console.ResetColor();
            Console.Write("]");
            Console.Write(ConsoleUtility.PadRightForMixedText(ItemName, 9));
        }
        else Console.Write(ConsoleUtility.PadRightForMixedText(ItemName, 12));

        Console.Write(" | ");

        if (ItemAtk != 0) Console.Write($"공격력 {(ItemAtk >= 0 ? "+" : "")}{ItemAtk} ");
        if (ItemDef != 0) Console.Write($"방어력 {(ItemDef >= 0 ? "+" : "")}{ItemDef} ");
        if (ItemHp != 0) Console.Write($"체  력 {(ItemHp >= 0 ? "+" : "")}{ItemHp} ");

        Console.Write(" | ");


    }


    public void PrintStoreItemDescription(bool withNumber = false, int idx = 0)
    {
        Console.Write("- ");
        // 장착관리 전용
        if (withNumber)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("{0} ", idx);
            Console.ResetColor();
        }
        else Console.Write(ConsoleUtility.PadRightForMixedText(ItemName, 12));

        if (ItemAtk != 0) Console.Write($"공격력 {(ItemAtk >= 0 ? "+" : "")}{ItemAtk} ");
        if (ItemDef != 0) Console.Write($"방어력 {(ItemDef >= 0 ? "+" : "")}{ItemDef} ");
        if (ItemHp != 0) Console.Write($"체  력 {(ItemHp >= 0 ? "+" : "")}{ItemHp}");

        if (IsPurchased)
        {
            Console.WriteLine("구매완료");
        }
        else
        {
            ConsoleUtility.PrintTextHighlights("", ItemPrice.ToString(), " G");
        }
    }

    internal void ToggleEquipStatus()
    {
        IsEquipped = !IsEquipped;
    }

    internal void Purchase()
    {
        IsPurchased = true;
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