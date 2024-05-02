// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Text_RPG;

// 퀘스트 조건에 대해 튜터님께 여쭤보기, 몬스터 카운트 하기
// 퀘스트 수락 -> 메인 화면으로 가기 Z가 퀘스트 수락 전 5번이 퀘스트 수락 후

public class QuestManager
{

    //퀘스트 목록
    QuestDifficultyReward KillWolf = new QuestDifficultyReward(10, 50); // 난이도 별 보상 (변수의 끝 영어가 난이도)
    QuestDifficultyReward KillGoblin = new QuestDifficultyReward(100, 500);

    //아이템 목록, 정보
    ItemInfo oldSword = new ItemInfo("낡은 검", 3, 0, 0, 0, 200);
    ItemInfo oldShield = new ItemInfo("낡은 방패", 0, 2, 1, 0, 100);
    ItemInfo longSword = new ItemInfo("롱 소드", 8, 0, 0, 0, 500);
    ItemInfo shortBow = new ItemInfo("숏 보우", 13, 0, 0, 0, 800);
    ItemInfo longBow = new ItemInfo("롱 보우", 18, 0, 0, 0, 1100);
    ItemInfo magicWand = new ItemInfo("마법 지팡이", 10, 0, 0, 10, 800);
    ItemInfo soulsWand = new ItemInfo("영혼의 지팡이", 15, 0, 0, 15, 1200);

    //몬스터 목록, 정보
    MonsterInfo wolf = new MonsterInfo("늑대", 80, 6);
    MonsterInfo goblin = new MonsterInfo("고블린", 120, 8);
    MonsterInfo samurai = new MonsterInfo("사무라이", 200, 15);
    MonsterInfo ghost = new MonsterInfo("유령", 150, 10);
    MonsterInfo ork = new MonsterInfo("오크", 250, 20);
    MonsterInfo dragon = new MonsterInfo("드래곤", 1000, 100);

    //진행중 띄우기 값
    bool isQuestWolf = false;
    bool isQuestGoblin = false;

    public void QuestMenu()
    {
        Console.Clear(); //화면정리 ( \n 한 줄 띄우기 )

        Console.WriteLine("\n ※ 퀘스트 목록 ※\n\n\n");
        Console.WriteLine(" ─────────────────────\n");

        Console.Write(" 1. - 늑대 퇴치 (D급)");
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine((isQuestWolf ? " (진행 중)" : ""));// 퀘스트 수락 시 진행 중을 띄우고싶다. 그러면 수락을 선택하면 여기에 진행 중만 띄우면 되는건데,
        Console.ResetColor();

        Console.Write(" 2. - 고블린 잡기 (B급)"); // 기본은 false 값으로하고 수락 했다는 true값을 가져와서 진행 중을 띄우면 되는건가
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine((isQuestGoblin ? " (진행 중)" : ""));// 퀘스트 수락 시 진행 중을 띄우고싶다. 그러면 수락을 선택하면 여기에 진행 중만 띄우면 되는건데,
        Console.ResetColor();

        Console.WriteLine(" \n─────────────────────\n");
        Console.WriteLine(" 0. 돌아가기\n");    

        int choiceQuest = QuestInformation.MenuChoice(0, 2); //선택지

        switch (choiceQuest)
        {
            case 0: QuestMenu(); break;
            case 1: QuestKillWolf(); break;
            case 2: QuestKillGoblin(); break;
        }
    }

    public void QuestKillWolf()
    {
        int wolfCount= 0;
        int totalWolfCount = 3;

        Console.Clear(); //화면정리

        Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
        Console.WriteLine(" - 늑대 ( " + wolfCount + " / " + totalWolfCount +" )\n\n");
        if (wolf.MonsterHp < 1)  // Battle에서 enemyHp가 0이 될때 카운트를 한다.
        {
            wolfCount++;
        }
        Console.WriteLine(" - 보상 -\n");
        Console.WriteLine(" Gold : " + KillWolf.QuestGold + ", Exp : " + KillWolf.QuestExp);
        Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : "+ oldSword.ItemPrice + "\n");
        Console.WriteLine(" 1. 수락");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 1))
        {
            case 0: QuestMenu(); break;
            case 1:
                {
                    isQuestWolf = true;
                    Console.Clear(); //화면정리 

                    Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
                    Console.WriteLine(" - 늑대 ( " + wolfCount + " / " + totalWolfCount + " )\n\n");
                    Console.WriteLine(" - 보상 - \n");
                    Console.WriteLine(" Gold : " + KillWolf.QuestGold + ", Exp : " + KillWolf.QuestExp);
                    Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
                    Console.WriteLine(" 퀘스트를 수락하였습니다. \n");
                    Console.WriteLine(" 0. 돌아가기\n");

                    switch (QuestInformation.MenuChoice(0, 0))
                    {
                        case 0: QuestMenu(); break;
                    }
                }    break;
        }
    }
    //public void QuestProtectHouseAccept() // 집을 지켜라 수락시
    //{
    //    Console.Clear(); //화면정리 

    //    Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
    //    Console.WriteLine(" 늑대 ( 0 / 3 )\n\n");
    //    Console.WriteLine(" - 보상 - \n");
    //    Console.WriteLine(" Gold : " + protectVillage.QuestGold + ", Exp : " + protectVillage.QuestExp);
    //    Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
    //    Console.WriteLine(" 퀘스트를 수락하였습니다. \n");
    //    Console.WriteLine(" 0. 돌아가기\n");

    //    switch (QuestInformation.MenuChoice(0, 0))
    //    {
    //        case 0: QuestMenu(); break;
    //    }

    //}

    public void QuestKillGoblin()
    {
        int goblinCount = 0;
        int totalGoblinCount = 5;

        Console.Clear(); //화면정리

        Console.WriteLine("\n 고블린을 잡아라 (등급 : B급)\n\n");
        Console.WriteLine(" - 고블린 ( "+ goblinCount + "/" + totalGoblinCount + ")\n\n");
        if (goblin.MonsterHp < 1) // Battle에서 enemyHp가 0이 될때 카운트를 한다.
        {
            goblinCount++;
        }
        Console.WriteLine(" - 보상 - \n");
        Console.WriteLine(" Gold : " + KillGoblin.QuestGold + ", Exp : " + KillGoblin.QuestExp);
        Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
        Console.WriteLine(" 1. 수락");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 1))
        {
            case 0: QuestMenu(); break;
            case 1:
                {
                    isQuestGoblin = true;
                    Console.Clear(); //화면정리

                    Console.WriteLine("\n 고블린을 잡아라 (등급 : B급)\n\n");
                    Console.WriteLine(" - 고블린 ( " + goblinCount + " / " + totalGoblinCount + " )\n\n"); // 조건에서 몬스터 수치 증가 시키기, if 문 사용
                    Console.WriteLine(" - 보상 - \n");
                    Console.WriteLine(" Gold : " + KillGoblin.QuestGold + ", Exp : " + KillGoblin.QuestExp);
                    Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
                    Console.WriteLine(" 퀘스트를 수락하였습니다.\n");
                    Console.WriteLine(" 0. 돌아가기\n");

                    switch (QuestInformation.MenuChoice(0, 0))
                    {
                        case 0: QuestMenu(); break;
                    }
                }    break;
        }
    }
    //public void QuestProtectVillageAccept() // 마을을 지켜라 수락시
    //{
    //    Console.Clear(); //화면정리

    //    Console.WriteLine("\n 몬스터를 잡아라 (등급 : B급)\n\n");
    //    Console.WriteLine(" 몬스터 ( 0 / 5 )\n\n"); // 조건에서 몬스터 수치 증가 시키기, if 문 사용
    //    Console.WriteLine(" - 보상 - \n");
    //    Console.WriteLine(" Gold : " + protectHouse.QuestGold + ", Exp : " + protectHouse.QuestExp);
    //    Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
    //    Console.WriteLine(" 퀘스트를 수락하였습니다.\n");
    //    Console.WriteLine(" 0. 돌아가기\n");

    //    switch (QuestInformation.MenuChoice(0, 0))
    //    {
    //        case 0: QuestMenu(); break;
    //    }
    //}
}