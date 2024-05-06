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

        Player player = new Player();
        //캐릭터 생성
        public void NewCharacter()
        {
            Console.Clear();
            images.CharacterName(player);

            Console.SetCursorPosition(114,45);
            player.Name = Console.ReadLine();

            
            //플레이어명 기입 검증
            if (player.Name == null || player.Name == "")
            {
                images.Error();
                NewCharacter();
                
            }
            else if(player.Name != null)
            {
                while (true)
                {
                    images.CharacterNameConfirm(player);

                    ConsoleKeyInfo choice = Console.ReadKey();

                    if (choice.Key == ConsoleKey.Z)
                    {
                        Newjob(player.Name);
                        break;
                    }
                    else if (choice.Key == ConsoleKey.X)
                    {
                        NewCharacter();
                        break;
                    }
                    else
                    {
                        images.Error();
                    }
                }

            }
        }

        //직업 선택
        private void Newjob(string playerName)
        {
            while (true)
            {
                Console.Clear();
                images.CharacterSelect();
                ConsoleKeyInfo choice = Console.ReadKey();

                if (choice.Key == ConsoleKey.D1 || choice.Key == ConsoleKey.NumPad1)
                {
                    while (true)
                    {
                        Console.Clear();
                        images.Accept_01();

                        ConsoleKeyInfo warriorSelect = Console.ReadKey(true);

                        if (warriorSelect.Key == ConsoleKey.Z)
                        {
                            player.SetStatus(playerName, "전사", 1, 0, 25, 25, 200, 100, 1500);
                            Console.Clear();
                            new Main().MainMenu(player);
                            break;
                        }
                        else if (warriorSelect.Key == ConsoleKey.X)
                        {
                            Newjob(playerName);
                            break;
                        }
                        else
                        {
                            images.Error();
                        }
                    }
                }
                else if (choice.Key == ConsoleKey.D2 || choice.Key == ConsoleKey.NumPad2)
                {
                    while (true)
                    {
                        Console.Clear();
                        images.Accept_02();

                        ConsoleKeyInfo archerSelect = Console.ReadKey(true);

                        if (archerSelect.Key == ConsoleKey.Z)
                        {
                            player.SetStatus(playerName, "궁수", 1, 0, 35, 15, 150, 150, 1500);
                            Console.Clear();
                            new Main().MainMenu(player);
                            break;
                        }
                        else if (archerSelect.Key == ConsoleKey.X)
                        {
                            Newjob(playerName);
                            break;
                        }
                        else
                        {
                            images.Error();
                        }
                    }
                }
                else if (choice.Key == ConsoleKey.D3 || choice.Key == ConsoleKey.NumPad3)
                {
                    while (true)
                    {
                        Console.Clear();
                        images.Accept_03();

                        ConsoleKeyInfo wizardSelect = Console.ReadKey(true);

                        if (wizardSelect.Key == ConsoleKey.Z)
                        {
                            player.SetStatus(playerName, "마법사", 1, 0, 5, 5, 100, 500, 1500);
                            Console.Clear();
                            new Main().MainMenu(player);
                            break;
                        }
                        else if (wizardSelect.Key == ConsoleKey.X)
                        {
                            Newjob(playerName);
                            break;
                        }
                        else
                        {
                            images.Error();
                        }
                    }
                }
                else if (choice.Key == ConsoleKey.D4 || choice.Key == ConsoleKey.NumPad4)
                {
                    while (true)
                    {
                        Console.Clear();
                        images.Accept_04();

                        ConsoleKeyInfo priestsSelect = Console.ReadKey(true);

                        if (priestsSelect.Key == ConsoleKey.Z)
                        {
                            player.SetStatus(playerName, "사제", 1, 0, 10, 10, 100, 100, 1500);
                            Console.Clear();
                            new Main().MainMenu(player);
                            break;
                        }
                        else if (priestsSelect.Key == ConsoleKey.X)
                        {
                            Newjob(playerName);
                            break;
                        }
                        else
                        {
                            images.Error();
                        }
                    }
                }
                else
                {
                    images.Error();
                }
            }
        }
    }      
}
