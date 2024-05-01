// See https://aka.ms/new-console-template for more information
using MeungSun1;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

// 내일 할 것 == 퀘스트 조건에 대해 튜터님께 여쭤보기, 퀘스트 수락 후 퀘스트 진행중 띄우기
// 퀘스트 수락 -> 메인 화면으로 가기

public class QuestManager
{
    //퀘스트 목록
    QuestDifficultyReward protectHouse = new QuestDifficultyReward(10, 50); // 난이도 별 보상 (변수의 끝 영어가 난이도)
    QuestDifficultyReward protectVillage = new QuestDifficultyReward(100, 500);

    //아이템 목록
    ItemInfo oldSword = new ItemInfo("낡은 검", 3, 0, 0, 200); // 아이템 정보
    ItemInfo oldShield = new ItemInfo("낡은 방패", 0, 2, 1, 100);

    //몬스터 목록
    MonsterInfo wolf = new MonsterInfo("늑대", 100, 8);
    
    
    public void QuestMenu()
    {
        Console.Clear(); //화면정리 ( \n 한 줄 띄우기 )

        Console.WriteLine("\n ※ 퀘스트 목록 ※\n\n\n");
        Console.WriteLine(" ─────────────────────\n");
        Console.WriteLine(" 1. 집 지키기 (B급)");
        Console.WriteLine(" 2. 마을 지키기 (D급)");
        Console.WriteLine(" \n─────────────────────\n");
        Console.WriteLine(" 0. 돌아가기\n");

        int choice = QuestInformation.MenuChoice(0, 2); //선택지

        switch (choice)
        {
            case 0: QuestMenu(); break;
            case 1: QuestProtectHouse(); break;
            case 2: QuestProtectVillage(); break;
        }
    }

    public void QuestProtectHouse()
    {
        Console.Clear(); //화면정리

        Console.WriteLine("\n 몬스터를 잡아라 (등급 : D급)\n\n");
        Console.WriteLine(" 몬스터 ( 0 / 5 )\n\n");
        Console.WriteLine(" - 보상 -\n");
        Console.WriteLine(" Gold : " + protectVillage.QuestGold + ", Exp : " + protectVillage.QuestExp);
        Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : "+ oldSword.ItemPrice + "\n");
        Console.WriteLine(" 1. 수락");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 1))
        {
            case 0: QuestMenu(); break;
            case 1: QuestProtectHouseAccept(); break;
        }
    }
    public void QuestProtectHouseAccept() // 집을 지켜라 수락시
    {
        Console.Clear(); //화면정리 

        Console.WriteLine("\n 몬스터를 잡아라 (등급 : D급)\n\n");
        Console.WriteLine(" 몬스터 ( 0 / 5 )\n\n"); // 조건에서 몬스터 수치 증가 시키기, if 문 사용
        // if() {}
        Console.WriteLine(" - 보상 - \n");
        Console.WriteLine(" Gold : " + protectVillage.QuestGold + ", Exp : " + protectVillage.QuestExp);
        Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
        Console.WriteLine(" 퀘스트를 수락하였습니다. \n");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 0))
        {
            case 0: QuestMenu(); break;
        }

    }

    public void QuestProtectVillage()
    {
        Console.Clear(); //화면정리

        Console.WriteLine("\n 몬스터를 잡아라 (등급 : B급)\n\n");
        Console.WriteLine(" 몬스터 ( 0 / 3 )\n\n");
        Console.WriteLine(" - 보상 - \n");
        Console.WriteLine(" Gold : " + protectHouse.QuestGold + ", Exp : " + protectHouse.QuestExp);
        Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
        Console.WriteLine(" 1. 수락");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 1))
        {
            case 0: QuestMenu(); break;
            case 1: QuestProtectVillageAccept(); break;
        }
    }
    public void QuestProtectVillageAccept() // 마을을 지켜라 수락시
    {
        Console.Clear(); //화면정리

        Console.WriteLine("\n 몬스터를 잡아라 (등급 : B급)\n\n");
        Console.WriteLine(" 몬스터 ( 0 / 3 )\n\n"); // 조건에서 몬스터 수치 증가 시키기, if 문 사용
        Console.WriteLine(" - 보상 - \n");
        Console.WriteLine(" Gold : " + protectHouse.QuestGold + ", Exp : " + protectHouse.QuestExp);
        Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
        Console.WriteLine(" 퀘스트를 수락하였습니다.\n");
        Console.WriteLine(" 0. 돌아가기\n");

        switch (QuestInformation.MenuChoice(0, 0))
        {
            case 0: QuestMenu(); break;
        }
    }
}