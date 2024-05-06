using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Text_RPG
{

    internal class Inventory // 포션, 장비, 골드 정도 들어가면될듯
    {
        //플레이어 정보
        Player player = new Player();

        private List<ItemInfo> inventory;

        private List<ItemInfo> storeInventory;

        private void InitializeGame()
        {
            player.SetStatus("Jiwon", "Programmer", 1, 0, 10, 5, 100, 10, 15000);

            inventory = new List<ItemInfo>();

            storeInventory = new List<ItemInfo>();
            ItemInfo oldSword = new ItemInfo("낡은 검", 3, 0, 0, 0, 200);
            ItemInfo oldShield = new ItemInfo("낡은 방패", 0, 2, 1, 0, 100);
            ItemInfo longSword = new ItemInfo("롱 소드", 8, 0, 0, 0, 500);
            ItemInfo shortBow = new ItemInfo("숏 보우", 13, 0, 0, 0, 800);
            ItemInfo longBow = new ItemInfo("롱 보우", 18, 0, 0, 0, 1100);
            ItemInfo magicWand = new ItemInfo("마법 지팡이", 10, 0, 0, 10, 800);
            ItemInfo soulsWand = new ItemInfo("영혼의 지팡이", 15, 0, 0, 15, 1200);
        }

        public void InventoryMenu()
        {

            Console.Clear();

            ConsoleUtility.ShowTitle(" - 인벤토리 -");
            Console.WriteLine(" 보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine(" [아이템 목록]");
            Console.WriteLine(" - 현재 소지금 : " + player.Gold + " G");
            Console.WriteLine("");
            Console.WriteLine(" 1. 장착관리");
            Console.WriteLine(" 0. 나가기");
            Console.WriteLine("");

            switch (QuestInformation.MenuChoice(0, 2))
            {
                case 0: InventoryMenu(); break;
                case 1: InventoryManagement(); break;
            }
        }

        public void InventoryManagement()
        {
            Console.Clear();

            ConsoleUtility.ShowTitle(" - 인벤토리 - 장착 관리 -");
            Console.WriteLine(" 보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine("");
            Console.WriteLine(" [아이템 목록]");
            Console.WriteLine("");
            Console.WriteLine(" 0. 나가기");

            int KeyInput = QuestInformation.MenuChoice(0, inventory.Count);

            switch (KeyInput)
            {
                case 0:
                    InventoryMenu();
                    break;
                default:
                    inventory[KeyInput - 1].ToggleEquipStatus();
                    InventoryManagement();
                    break;
            }
        }
    }
}