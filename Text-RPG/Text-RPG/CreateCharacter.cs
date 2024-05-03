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

        //캐릭터 생성
        public string NewCharacter()
        {
            Console.Clear();
            //images.CharacterName();
            Console.WriteLine("**********************************************");
            Console.WriteLine("플레이어명: ");
            Console.WriteLine("**********************************************");
            Console.SetCursorPosition(11,1);
            string playerName = Console.ReadLine();
            Newjob("");
            if (playerName != null )
            {
                return playerName;
            }
            else
            {
                Console.WriteLine("이름을 입력해주세요");
            }
            return playerName;
            
        }

        //직업 선택
        private void Newjob(string playerName)
        {
            //Main main = new Main();

            Console.Clear();
            //images.CharaterSelect
            Console.WriteLine("**********************************************");
            Console.WriteLine("1.전사, 2.궁수, 3.마법사, 4.사제 ");
            Console.WriteLine("**********************************************");
            int choice = ConsoleUtility.PromptChoice(1, 4);

            switch (choice)
            {
                
                //전사
                case 1:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("확정하시겠습니까?");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("1.예, 2.아니오");

                    ConsoleUtility.CharacterChoice(1, 2);
                    Player.InitializeGame(playerName, "전사", 25, 25, 200, 100);
                    break;
                //궁수
                case 2:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("확정하시겠습니까?");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("1.예, 2.아니오");

                    ConsoleUtility.CharacterChoice(1, 2);
                    Player.InitializeGame(playerName, "궁수", 35, 15, 150, 150);
                    break;
                //마법사
                case 3:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("확정하시겠습니까?");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("1.예, 2.아니오");

                    ConsoleUtility.CharacterChoice(1, 2);
                    Player.InitializeGame(playerName, "마법사", 5, 5, 100, 500);
                    break;
                //사제
                case 4:
                    //images.CharaterSelect
                    Console.Clear();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("확정하시겠습니까?");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("1.예, 2.아니오");

                    ConsoleUtility.CharacterChoice(1, 2);
                    Player.InitializeGame(playerName, "사제", 10, 10, 100, 100);
                    break;
            }
        }
    }      
}
