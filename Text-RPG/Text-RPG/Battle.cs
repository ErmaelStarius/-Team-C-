using System;
using System.Xml.Serialization;

namespace Text_RPG
{
    internal class Battle
    {
        //현재 플레이어와 적의 수치는 임시로 되어있으므로 향후 수정할 계획




        float playerHp = 100f;           //임시 플레이어 Hp
        float playerAttack = 9f;       //임시 플레이어 공격력
        float playerDeffense = 3f;      //임시 플레이어 방어력
        float enemyHp = 80f;            //임시 몬스터 Hp
        float enemyAttack = 10f;         //임시 몬스터 공격력
        float enemyDeffense = 3f;       //임시 몬스터 방어력
        Random random = new Random();   //난수
        float[] RandomDamage = { 0.9f, 1.0f, 1.1f};  //플레이어의 데미지에서 90%, 100% 110% 중 하나가 적용

        
        
        public void BattlePhase()   //전투과정
        {


            while (playerHp > 0 && enemyHp > 0)

            {
                if(playerHp > 100f)
                {
                    playerHp = 100f;

                }

                Console.WriteLine("");

                BattleStats(); //플레이어와 적의 체력 상태

                MyTurn();  //내턴

                EnemyTurn();  //적의턴 그러고 적이 죽으면 다시 플레이어턴으로 돌아간다.
                
            }
        }

        private void EnemyTurn()
        {
            
            float EnemyDamage = enemyAttack * RandomDamage[random.Next(RandomDamage.Length)] - playerDeffense;

            if (enemyHp > 0)      //적의 턴
            {

                playerHp -= (enemyAttack - playerDeffense);                               //적의 데미지는 공격력 - 방어력
                Console.WriteLine($"적은 당신에게 {EnemyDamage.ToString("N1")} 만큼의 데미지를 입혔습니다.");
                Console.WriteLine("");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("당신은 적을 쓰러뜨렸습니다!!"); //적을 쓰러뜨림_보상추가 예정
            }
            if (playerHp <= 0)
            {
                Console.Clear();
                Console.WriteLine("");
                Console.WriteLine("당신은 죽었습니다!");  //사망하고 저장한 시점으로 돌아가거나 리셋
            }
        }

        private void MyTurn()  //플레이어의 차례
        {
            float PlayerDamage = playerAttack * RandomDamage[random.Next(RandomDamage.Length)];
            float MyAttack = PlayerDamage - enemyDeffense;
            float MySkillAttack = PlayerDamage * 2 - enemyDeffense;

            Console.WriteLine("플레이어의 차례입니다.");
            Console.WriteLine("");
            Console.WriteLine("무엇을 하시겠습니까?.");
            Console.WriteLine("");
            Console.WriteLine("1. 공격 | 2. 스킬 | 3. 아이템 | 4. 도망치기");
            Console.WriteLine("");
            Console.Write("행동을 고르싶시오 >>   ");
            string choice = Console.ReadLine();
            if (choice == "1")                             
            {
                Console.Clear();
                enemyHp -= (PlayerDamage - enemyDeffense);                                                        //현재 플레이어의 데미지는 공격력 - 적의 방어력
                Console.WriteLine($"당신은 적에게 {MyAttack.ToString("N1")} 만큼의 데미지를 입혔습니다.");   //향후 "적" 에 몬스터 이름이 들어갈 계획
                Console.WriteLine("");
            }
            else if (choice == "2")
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("당신은 강한 공격을 썻다!");
                Console.WriteLine("");
                enemyHp -= (PlayerDamage * 2) - enemyDeffense;                                  //향후 스킬을 넣을 계획
                Console.WriteLine($"당신은 적에게 {MySkillAttack.ToString("N1")} 만큼의 데미지를 입혔습니다.");
                Console.WriteLine("");
            }
            else if (choice == "3")
            {

                OpenInventory();           
                
            }
            else if (choice == "4")
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("당신은 도망쳤다!");   //도망치기_패널티로 돈이 떨어짐
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("잘못 입력헀습니다. 다시 눌러주십시오");
                Console.WriteLine("");
                BattleStats();
                MyTurn();
            }
        }

        private void OpenInventory() //인벤토리 열기
        {
            Console.Clear();
            BattleStats();
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("인벤토리에 있는 아이템 중에서 사용할 것을 고르세요.");
            Console.WriteLine("");
            Console.WriteLine("1. 회복포션 | 2. 돌아가기");
            Console.WriteLine("");
            Console.Write("행동을 고르싶시오 >>   ");
            string choiceitem = Console.ReadLine();
            if (choiceitem == "1")
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("당신은 포션을 사용했다.!");   //포션 사용
                Console.WriteLine("");
                Console.WriteLine("당신은 체력이 10만큼 회복했습니다.");
                Console.WriteLine("");
                playerHp += 10;
                BattlePhase();
            }
            else if (choiceitem == "2")
            {
                Console.WriteLine("");
                Console.Clear();
                BattleStats();
                MyTurn();
            }
            else
            {
                Console.WriteLine("");
                Console.Clear();
                Console.WriteLine("잘못 입력헀습니다. 다시 눌러주십시오");
                Console.WriteLine("");
                OpenInventory();
            }
        }

        public void RandomEnemyCount()
        {
            int EnemyCount = random.Next(0, 4);

            if (EnemyCount == 0)
            {
               
            }
        }
        public void BattleStats()
        {
            
            Console.WriteLine("=======================");
            Console.WriteLine("                              ");
            Console.WriteLine("  당신의 체력 : " + playerHp.ToString("N1")  );
            Console.WriteLine("                              ");
            Console.WriteLine("   적의 체력 : " + enemyHp.ToString("N1")    );
            Console.WriteLine("                              ");
            Console.WriteLine("=======================");
            Console.WriteLine("");
        }
    }
}