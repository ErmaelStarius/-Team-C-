using System.Reflection.Emit;

namespace Text_RPG
{
    public class Status
    {
        CreateCharacter name = new CreateCharacter();
        
        //상태창
        public void StatusMenu(Player player, QuestGameManager gameManager)
        {

            Console.Clear();

            ConsoleUtility.ShowTitle("상태보기");
            Console.WriteLine("캐릭터의 정보가 표기됩니다.");

            ConsoleUtility.PrintTextHighlights($"Lv. ", player.Level.ToString("00"));
            Console.WriteLine("");
            Console.WriteLine($"{player.Name} ({player.Job})");
            
            ConsoleUtility.PrintTextHighlights("공격력 :", (player.Atk).ToString());
            ConsoleUtility.PrintTextHighlights("방어력 :", (player.Def).ToString());
            ConsoleUtility.PrintTextHighlights("체  력 :", (player.Hp).ToString());
            ConsoleUtility.PrintTextHighlights("마  나 :", (player.Mp).ToString());
            ConsoleUtility.PrintTextHighlights("Gold :", player.Gold.ToString());
            Console.WriteLine("");

            Console.WriteLine("0. 뒤로가기");
            Console.WriteLine("");

            switch (ConsoleUtility.PromptChoice(0, 0))
            {
                case 0:
                    new Main().MainMenu(player, gameManager);
                    break;
            }
        }
    }
} 