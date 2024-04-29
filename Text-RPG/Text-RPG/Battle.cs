using System.Xml.Serialization;

namespace Text_RPG
{
    internal class Battle
    {
        //현재 플레이어와 적의 수치는 임시로 되어있으므로 향후 수정할 계획

        int playerHp = 100;           //임시 플레이어 Hp
        int playerAttack = 10;       //임시 플레이어 공격력
        int playerDeffense = 3;      //임시 플레이어 방어력
        int enemyHp = 40;            //임시 몬스터 Hp
        int enemyAttack = 10;         //임시 몬스터 공격력
        int enemyDeffense = 3;       //임시 몬스터 방어력
        Random random = new Random();   //적이 스킬 이 있을결우
        
        public void BattlePhase()
        {
            Console.WriteLine("적이 나타났다!");

            while (playerHp > 0 && enemyHp > 0)

            {
                
                Console.WriteLine("");
                BattleStats();

                Console.WriteLine("플레이어의 차례입니다.");
                Console.WriteLine("");
                Console.WriteLine("무엇을 하시겠습니까?.");
                Console.WriteLine("");
                Console.WriteLine("1. 공격 | 2. 스킬");
                Console.WriteLine("");
                Console.Write("행동을 고르싶시오 >>   ");
                string choice = Console.ReadLine();
                if (choice == "1")                             //플레이어의 차례
                {
                    Console.Clear();
                    enemyHp -= (playerAttack - enemyDeffense);                                                        //현재 플레이어의 데미지는 공격력 - 적의 방어력
                    Console.WriteLine($"당신은 적에게 {playerAttack - enemyDeffense} 만큼의 데미지를 입혔습니다.");   //향후 "적" 에 몬스터 이름이 들어갈 계획
                    Console.WriteLine("");
                }
                else if (choice == "2")
                {
                    Console.WriteLine("");
                    Console.Clear();
                    Console.WriteLine("당신은 강한 공격을 썻다!");
                    Console.WriteLine("");
                    enemyHp -= (playerAttack * 2) - enemyDeffense;                                  //향후 스킬을 넣을 계획
                    Console.WriteLine($"당신은 적에게 {(playerAttack * 2) - enemyDeffense} 만큼의 데미지를 입혔습니다.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("");
                    Console.Clear() ;   
                    Console.WriteLine("잘못 입력헀습니다. 다시 눌러주십시오");
                    Console.WriteLine("");                    
                    BattlePhase();
                }

                if (enemyHp > 0)      //적의 턴
                {
                    
                    playerHp -= (enemyAttack - playerDeffense);                               //적의 데미지는 공격력 - 방어력
                    Console.WriteLine($"적은 당신에게 {enemyAttack - playerDeffense} 만큼의 데미지를 입혔습니다.");
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
                    Console.WriteLine("당신은 죽었습니다!");  //사망하고 저장한 시점으로 돌아가거나 리셋
                }
            }
        }
        public void BattleStats()
        {
            Console.WriteLine("=====================");
            Console.WriteLine("                              ");
            Console.WriteLine("  당신의 체력 : " + playerHp  );
            Console.WriteLine("                              ");
            Console.WriteLine("   적의 체력 : " + enemyHp    );
            Console.WriteLine("                              ");
            Console.WriteLine("=====================");
            Console.WriteLine("");
        }
    }
}