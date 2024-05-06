// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Text_RPG;

//  몬스터 카운트 하기, 완료 후 보상받기 battle 이랑 quest랑 연결
namespace Text_RPG
{
    
    public class QuestManager
    {
        Main main = new Main();
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
        MonsterInfo wolf = new MonsterInfo("늑대", 80, 6, 3);
        MonsterInfo goblin = new MonsterInfo("고블린", 120, 8, 4);
        MonsterInfo samurai = new MonsterInfo("사무라이", 200, 15, 8);
        MonsterInfo ghost = new MonsterInfo("유령", 150, 10, 0);
        MonsterInfo ork = new MonsterInfo("오크", 250, 20, 10);
        MonsterInfo dragon = new MonsterInfo("드래곤", 1000, 100, 30);

        //진행중, 완료 띄우기 값

        bool isWolfAccept = true;
        bool isWolfQuest = false;

        bool isGoblinAccept = true;
        bool isGoblinQuest = false;


        int wolfCount = 0; //퍼블릭 or 메소드
        int totalWolfCount = 3;
        int goblinCount = 0;
        int totalGoblinCount = 5;

        public void KillWolfCount()
        {
            wolfCount++;
        }


        public void QuestMenu(Player player, QuestGameManager gameManager)
        {
            Console.Clear(); //화면정리 ( \n 한 줄 띄우기 )
            Console.WriteLine("\n ※ 퀘스트 목록 ※\n\n\n");
            Console.WriteLine(" ─────────────────────\n");
            Console.Write(" 1 - 늑대 퇴치 (D급)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            if (isWolfAccept == false)
            {
                Console.WriteLine(" 진행 중");
            }
            else if (isWolfQuest == true) // 보상 받기 이후에 뜨면 좋겠다.
            {
                Console.WriteLine(" 완료");
            }

            Console.WriteLine();

            Console.ResetColor();

            Console.Write(" 2 - 고블린 잡기 (B급)");
            Console.ForegroundColor = ConsoleColor.Magenta;
            
            if (isGoblinAccept == false)
            {
                Console.WriteLine(" 진행 중");
            }
            else if (isGoblinQuest == true)
            {
                Console.WriteLine(" 완료");
            }
            Console.WriteLine();

            Console.ResetColor();

            Console.WriteLine(" \n─────────────────────\n");
            Console.WriteLine(" 0. 돌아가기\n");

            int choiceQuest = QuestInformation.MenuChoice(0, 2); //선택지

            switch (choiceQuest)
            {
                case 0: gameManager.main.MainMenu(player, gameManager); break; //메인화면으로 가게하기
                case 1: QuestKillWolf(player, gameManager); break;
                case 2: QuestKillGoblin(player, gameManager); break;
            }
        }

        public void QuestKillWolf(Player player, QuestGameManager gameManager)
        {

            // (wolf.MonsterHp < 1)

            Console.Clear(); //화면정리

            Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
            Console.WriteLine(" - 늑대 ( " + wolfCount + " / " + totalWolfCount + " )\n\n");
            if (wolf.MonsterHp < 1)  // Battle에서 enemyHp가 0이 될때 카운트를 한다. 그러려면 Battle 에서 MonsterHp를 가져와야한다
            {                       // 아니면 다른 카운트 방법이 있을까?
                wolfCount++;
            }
            Console.WriteLine(" - 보상 -\n");
            Console.WriteLine(" Gold : " + KillWolf.QuestGold + ", Exp : " + KillWolf.QuestExp);
            Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
            Console.WriteLine((isWolfAccept ? " 1. 수락" : ""));
            if (wolfCount == totalWolfCount)
            {
                Console.WriteLine(" 2. 보상 받기");
            }
            Console.WriteLine(" 0. 돌아가기\n");

            switch (QuestInformation.MenuChoice(0, 2))
            {
                case 0: QuestMenu(player, gameManager); break;
                case 1:
                    {
                        isWolfAccept = false;

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
                            case 0: QuestMenu(player, gameManager); break;
                        }
                    }
                    break;
                case 2:
                    {
                        isWolfAccept = true;
                        isWolfQuest = true;
                        Console.Clear(); //화면정리 

                        Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
                        Console.WriteLine(" - 늑대 ( " + wolfCount + " / " + totalWolfCount + " )\n\n");
                        Console.WriteLine(" - 보상 - \n");
                        Console.WriteLine(" Gold : " + KillWolf.QuestGold + ", Exp : " + KillWolf.QuestExp);
                        Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
                        Console.WriteLine(" 퀘스트 보상을 받았습니다. \n");
                        Console.WriteLine(" 0. 돌아가기\n");

                        switch (QuestInformation.MenuChoice(0, 0))
                        {
                            case 0: QuestMenu(player, gameManager); break;
                        }
                    }
                    break;
            }
        }

        public void QuestKillGoblin(Player player, QuestGameManager gameManager)
        {


            Console.Clear(); //화면정리

            Console.WriteLine("\n 고블린을 잡아라 (등급 : B급)\n\n");
            Console.WriteLine(" - 고블린 ( " + goblinCount + " / " + totalGoblinCount + ")\n\n");
            if (goblin.MonsterHp < 1) // Battle에서 enemyHp가 0이 될때 카운트를 한다.
            {
                goblinCount++;
            }
            Console.WriteLine(" - 보상 - \n");
            Console.WriteLine(" Gold : " + KillGoblin.QuestGold + ", Exp : " + KillGoblin.QuestExp);
            Console.WriteLine(" " + oldShield.ItemName + " / 방어력 : " + oldShield.ItemDef + " , 판매가격 : " + oldShield.ItemPrice + "\n");
            Console.WriteLine((isGoblinAccept ? " 1. 수락" : ""));
            if (goblinCount == totalGoblinCount)
            {
                Console.WriteLine(" 2. 보상 받기");
            }
            Console.WriteLine(" 0. 돌아가기\n");

            switch (QuestInformation.MenuChoice(0, 2))
            {
                case 0: QuestMenu(player, gameManager); break;
                case 1:
                    {
                        isGoblinAccept = false;

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
                            case 0: QuestMenu(player, gameManager); break;
                        }
                    }
                    break;
                case 2:
                    {
                        isGoblinAccept = true;
                        isGoblinQuest = true;

                        Console.Clear(); //화면정리 

                        Console.WriteLine("\n 늑대를 잡아라 (등급 : D급)\n\n");
                        Console.WriteLine(" - 늑대 ( " + wolfCount + " / " + totalWolfCount + " )\n\n");
                        Console.WriteLine(" - 보상 - \n");
                        Console.WriteLine(" Gold : " + KillWolf.QuestGold + ", Exp : " + KillWolf.QuestExp);
                        Console.WriteLine(" " + oldSword.ItemName + " / 공격력 : " + oldSword.ItemAtk + " , 판매가격 : " + oldSword.ItemPrice + "\n");
                        Console.WriteLine(" 퀘스트 보상을 받았습니다. \n");
                        Console.WriteLine(" 0. 돌아가기\n");

                        switch (QuestInformation.MenuChoice(0, 0))
                        {
                            case 0: QuestMenu(player, gameManager); break;
                        }
                        break;
                    }
                        
            }
        }
    }
}