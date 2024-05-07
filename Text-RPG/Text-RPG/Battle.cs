using System;
using System.Numerics;
using System.Xml.Serialization;

namespace Text_RPG
{
    internal class Battle
    {

        Images images = new Images();
        Player player = new Player();


        //현재 플레이어와 적의 수치는 임시로 되어있으므로 향후 수정할 계획


        QuestManager questManager;
        string playername;
        float playerHp;//임시 플레이어 Hp
        float playerAttack;        
        float playerDeffense;    //임시 플레이어 방어력
        float playerExp;
        float playerGold;
        string Log;
        string enemyname;
        float enemyHp;            //임시 몬스터 Hp
        float enemyAttack;        //임시 몬스터 공격력
        float enemyDeffense;    //임시 몬스터 방어력
        float enemyExp;
        float enemyGold;
        Random random = new Random();   //난수
        float playerMp;
        float[] RandomDamage = { 0.9f, 1.0f, 1.1f};  //플레이어의 데미지에서 90%, 100% 110% 중 하나가 적용

        
        public void BattlePhase(Player player, QuestGameManager gameManager)   //전투과정
        {
            questManager = gameManager.questManager;
            playername = player.Name;
            playerHp = player.Hp;
            playerAttack = player.Atk;
            playerDeffense = player.Def;
            playerMp = player.Mp;
            playerExp = player.Exp;
            playerGold = player.Gold;

            
            while (playerAttack > 0 && enemyHp > 0)
            {
                MonsterAppearRandom();
                //
                MyTurn(player, gameManager);  //내턴
                if (enemyHp <= 0)
                {
                    Battle_Reward();
                    break;
                }
                ContinueTurn();
                EnemyTurn(player, gameManager);  //적의턴 그러고 적이 죽으면 다시 플레이어턴으로 돌아간다.

            }
        }

        private void ContinueTurn()
        {           
            BattleStats();
            Console.Write("적의 턴입니다. 이어갈려면 아무 키를 눌러 주세요. >>  ");
            Console.ReadKey();
            Console.Clear();            
        }

        private void EnemyTurn(Player player, QuestGameManager gameManager)
        {
            
            float EnemyDamage = enemyAttack * RandomDamage[random.Next(RandomDamage.Length)] - playerDeffense;

            if (enemyHp > 0)      //적의 턴
            {

                playerAttack -= (enemyAttack - playerDeffense);                               //적의 데미지는 공격력 - 방어력
                Console.WriteLine($"적은 당신에게 {EnemyDamage.ToString("N1")} 만큼의 데미지를 입혔습니다.");
                
            }
            else
            {
                Battle_Reward();
            }
            if (playerHp <= 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("당신은 죽었습니다!");  //사망하고 저장한 시점으로 돌아가거나 
                Images images = new Images();
                images.Die();
            }
        }

        public float Battle_Reward() //보상
        {
            if (enemyHp < 0)
            {
                if (enemyname == "늑대")
                {
                    questManager.KillWolfCount();
                }
                if (enemyname == "고블린")
                {
                    questManager.KillGoblinCount();
                }
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("당신은 적을 쓰러뜨렸습니다!!"); //적을 쓰러뜨림_보상추가 예정
                Console.WriteLine($"당신은 {enemyExp} 만큼의 경험치와 {enemyGold}를 획득했습니다!"); //적을 쓰러뜨림_보상추가 예정
            }
                playerExp += enemyExp;
                playerGold += enemyGold;
                return playerExp + playerGold;


        }

        public void MyTurn(Player player, QuestGameManager gameManager)  //플레이어의 차례
        {
            float PlayerDamage = playerAttack * RandomDamage[random.Next(RandomDamage.Length)];
            float MyAttack = PlayerDamage - enemyDeffense;
            float MySkillAttack = PlayerDamage * 2 - enemyDeffense;
            
            BattleStats();
            Console.WriteLine("1. 공격 | 2. 스킬 | 3. 아이템 | 4. 도망치기");
            Console.WriteLine();
            Console.Write("행동을 고르싶시오 >>   ");
            string choice = Console.ReadLine();
            if (choice == "1")                             
            {
                Console.WriteLine();
                Console.Clear();
                enemyHp -= (PlayerDamage - enemyDeffense);                                                        //현재 플레이어의 데미지는 공격력 - 적의 방어력
                Console.WriteLine($"{playername}은 적에게 {MyAttack.ToString("N1")} 만큼의 데미지를 입혔습니다.");   //향후 "적" 에 몬스터 이름이 들어갈 계획
                
            }
            else if (choice == "2")
            {
                Battle_Skill(player, gameManager);
            }
            else if (choice == "3")
            {

                OpenInventory(player, gameManager);           
                
            }
            else if (choice == "4")
            {
                Console.Clear();
                Console.WriteLine("당신은 도망쳤다!");   //도망치기_패널티로 돈이 떨어짐
                gameManager.main.MainMenu(player, gameManager);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("잘못 입력헀습니다. 다시 눌러주십시오");
                MyTurn(player, gameManager);
            }
        }

        public void OpenInventory(Player player, QuestGameManager gameManager) //인벤토리 열기
        {
            Console.Clear();
            BattleStats();
            Console.WriteLine("1. 회복포션 | 2. 돌아가기");
            Console.WriteLine("");
            Console.Write("행동을 고르싶시오 >>   ");
            string choiceitem = Console.ReadLine();
            if (choiceitem == "1")
            {
                Console.Clear();
                Console.WriteLine("당신은 포션을 사용해 10 만큼 회복했다.!");   //포션 사용
                playerHp += 10;
                MyTurn(player, gameManager);
            }
            else if (choiceitem == "2")
            {
                Console.Clear();
                MyTurn(player, gameManager);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("잘못 입력헀습니다. 다시 눌러주십시오");
                OpenInventory(player, gameManager);
            }
        }
        public void BattleStats()
        {
            
            Console.WriteLine("===============================");
            Console.WriteLine("                              ");
            Console.WriteLine("  당신의 체력 : " + playerHp.ToString("N1")  );
            Console.WriteLine("                              ");
            Console.WriteLine("  당신의 마력 : " + playerMp.ToString("N1"));
            Console.WriteLine("                              ");
            Console.WriteLine($"  {enemyname}의 체력 : " + enemyHp.ToString("N1")    );
            Console.WriteLine("                              ");
            Console.WriteLine("===============================");
            Console.WriteLine("");
        }
        private void Battle_Skill(Player player, QuestGameManager gameManager)    //스킬
        {
            float PlayerDamage = playerAttack * RandomDamage[random.Next(RandomDamage.Length)];
            float MySkillAttack = PlayerDamage * 2 - enemyDeffense;
            float MySkillAttack2 = PlayerDamage * 3 - enemyDeffense;

            Console.Clear();
            BattleStats();
            Console.WriteLine("1. 강한공격 10Mp | 2. 초강력 베기 50Mp ");
            Console.WriteLine("");
            Console.Write("행동을 고르싶시오 >>   ");
            string choiceskill = Console.ReadLine();
            if (choiceskill == "1")
            {
               
                if (playerMp >= 10)
                {
                    Console.Clear();
                    Console.WriteLine($"당신은 적에게 강한공격을 써서 {MySkillAttack.ToString("N1")} 만큼의 데미지를 입혔습니다.");
                    enemyHp -= MySkillAttack;
                    playerMp -= 10;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("당신은 마나가 부족하여 스킬을 쓸 수 없습니다.");
                    MyTurn(player, gameManager);
                }
            }
            else if (choiceskill == "2")
            {
                if (playerMp >= 50)
                {
                    Console.Clear();
                    Console.WriteLine($"당신은 적에게 초강력베기를 써서 {MySkillAttack2.ToString("N1")} 만큼의 데미지를 입혔습니다.");
                    
                    enemyHp -= MySkillAttack2;                              //향후 스킬을 넣을 계획
                    playerMp -= 50;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("당신은 마나가 부족하여 스킬을 쓸 수 없습니다.");
                    MyTurn(player, gameManager);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("잘못 눌렀습니다.");
                MyTurn(player, gameManager);
            }
        }
        public void MonsterAppearRandom()
        {


            int MonsterRandom = random.Next(0, 6);
            switch (MonsterRandom)
            {
                case 0:
                    Log = "늑대가 나타났다!";
                    enemyname = "달빛늑대";
                    enemyHp = 50;
                    enemyAttack = 10;
                    enemyDeffense = 0;
                    enemyExp = 100;
                    enemyGold = 200;
                    images.BattlePage_Wolf(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
                case 1:
                    Log = "고블린이 나타났다!";
                    enemyname = "홉고블린";
                    enemyHp = 100;
                    enemyAttack = 20;
                    enemyDeffense = 2;
                    enemyExp = 200;
                    enemyGold =  300;
                    images.BattlePage_Goblin(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
                case 2:
                    Log = "저승사자가 나타났다!";
                    enemyname = "저승사자";
                    enemyHp = 80;
                    enemyAttack = 20;
                    enemyDeffense = 10;
                    enemyExp = 200;
                    enemyGold = 500;
                    images.BattlePage_Ghost(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
                case 3:
                    Log = "사무라이가 나타났다!";
                    enemyname = "사무라이";
                    enemyHp = 200;
                    enemyAttack = 30;
                    enemyDeffense = 5;
                    enemyExp = 1000;
                    enemyGold = 500;
                    images.BattlePage_Samurai(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
                case 4:
                    Log = "오크전사가 나타났다!";
                    enemyname = "오크전사";
                    enemyHp = 150;
                    enemyAttack = 20;
                    enemyDeffense = 10;
                    enemyExp = 800;
                    enemyGold = 600;
                    images.BattlePage_Orc(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
                case 5:
                    Log = "다크드래곤이 나타났다!";
                    enemyname = "다크드래곤";
                    enemyHp = 999;
                    enemyAttack = 35;
                    enemyDeffense = 15;
                    enemyExp = 9999;
                    enemyGold = 9999;
                    images.BattlePage_dragon(playerHp.ToString("N1"), playerMp.ToString("N1"), Log, enemyname, (int)enemyHp, (int)enemyAttack, (int)enemyDeffense, (int)enemyExp, (int)enemyGold);
                    break;
            }
        }
    }   
}