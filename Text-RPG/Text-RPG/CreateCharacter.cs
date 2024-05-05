using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{
    internal class CreateCharacter
    {
        Images images = new Images();
        Player player;
        //캐릭터 생성
        public void NewCharacter()
        {
            Console.Clear();
            //images.CharacterName();
            Console.WriteLine("**********************************************\n");
            Console.WriteLine("플레이어명: \n");
            Console.WriteLine("**********************************************");
            Console.SetCursorPosition(12,2);
            string playerName = Console.ReadLine();

            
            //플레이어명 기입 검증
            if (string.IsNullOrEmpty(playerName))
            {
                Console.Clear();
                Console.WriteLine("플레이어명을 입력해주세요");
                Thread.Sleep(1000);
                NewCharacter();
                
            }
            else 
            {
                Console.Clear();
                Console.WriteLine("**********************************************\n");
                Console.WriteLine($"   플레이어명: {playerName}으로 하시겠습니까?\n");
                Console.WriteLine("               1.예 2.아니오                  \n");
                Console.WriteLine("**********************************************");
                Console.Write(">> ");
                int choice = ConsoleUtility.PromptChoice(1, 2);

                switch (choice)
                {
                    case 1:
                        Newjob(playerName);
                        break;
                    case 2:
                        NewCharacter();
                        break;
                }
            }
        }

        //직업 선택
        private void Newjob(string playerName)
        {
            

            Console.Clear();
            //images.CharaterSelect
            Console.WriteLine("**********************************************\n");
            Console.WriteLine($"      1.전사, 2.궁수, 3.마법사, 4.사제       \n");
            Console.WriteLine("**********************************************");
            Console.Write(">> ");
            int choice = ConsoleUtility.PromptChoice(1, 4);

            switch (choice)
            {
                
                //전사
                case 1:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("          '전사'로 확정 하시겠습니까?         \n");
                    Console.WriteLine("               1.예, 2.아니오                 \n");
                    Console.WriteLine("**********************************************");
                    Console.Write(">> ");

                    int warriorSelect = ConsoleUtility.PromptChoice(1, 2);
                    
                    if (warriorSelect == 1)
                    {
                        Console.Clear();
                        player = new Player(playerName, "전사", 1, 0, 25, 25, 200, 100, 1500);
                        // new Main().MainMenu(player);
                        GameManager gameManager = new GameManager();
                        gameManager.main.MainMenu(player, gameManager);
                    }
                    else
                    {
                        Newjob(playerName);
                    }

                    break;
                //궁수
                case 2:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("          '궁수'로 확정 하시겠습니까?         \n");
                    Console.WriteLine("               1.예, 2.아니오                 \n");
                    Console.WriteLine("**********************************************");
                    Console.Write(">> ");

                    int archerSelect = ConsoleUtility.PromptChoice(1, 2);
                    
                    if (archerSelect == 1)
                    {
                        player = new Player(playerName, "궁수", 1, 0, 35, 15, 150, 150, 1500);
                        Console.Clear();
                        GameManager gameManager = new GameManager();
                        gameManager.main.MainMenu(player, gameManager);
                    }
                    else
                    {
                        Newjob(playerName);
                    }
                    break;
                //마법사
                case 3:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("          '마법사'로 확정 하시겠습니까?         \n");
                    Console.WriteLine("               1.예, 2.아니오                 \n");
                    Console.WriteLine("**********************************************");
                    Console.Write(">> ");

                    int wizardSelect = ConsoleUtility.PromptChoice(1, 2);

                    if (wizardSelect == 1)
                    {
                        player = new Player(playerName, "마법사", 1, 0, 5, 5, 100, 500, 1500);
                    Console.Clear();
                        GameManager gameManager = new GameManager();
                        gameManager.main.MainMenu(player, gameManager);
                    }
                    else
                    {
                        Newjob(playerName);
                    }
                    break;
                //사제
                case 4:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************\n");
                    Console.WriteLine("          '사제'로 확정 하시겠습니까?         \n");
                    Console.WriteLine("               1.예, 2.아니오                 \n");
                    Console.WriteLine("**********************************************");
                    Console.Write(">> ");

                    int priestsSelect = ConsoleUtility.PromptChoice(1, 2);

                    if (priestsSelect == 1)
                    {
                        player = new Player(playerName, "사제", 1, 0, 10, 10, 100, 100, 1500);
                        Console.Clear();
                        GameManager gameManager = new GameManager();
                        gameManager.main.MainMenu(player, gameManager);
                    }
                    else
                    {
                        Newjob(playerName);
                    }
                break;
            }
        }
    }      
}
