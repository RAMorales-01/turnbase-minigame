using System;
using System.Threading;
using Equipment;
using GameCharacters;

namespace GameFunctions
{
    public enum ItemCategory
    {
        Weapons = 1,
        Protection = 2,
        Healing = 3
    }
    internal class EquipmentItemStore
    {
        internal static object? Shop(PlayerChar player)
        {
            Console.Clear();
            Console.WriteLine("What are you buying?\n");
            Console.WriteLine("1- Weapons\n2- Shield/Armor\n3- Healing Items\n");
            Console.Write(": ");
            string? input = Console.ReadLine();
            
            if(!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Input not valid, you must choose only the presented options");
            }
            else
            {
                ItemCategory selectedCategory = (ItemCategory)choice;
                return Shopping.HandleShoppingChoice(player, selectedCategory);
            }

            return null;
        }
        internal class Shopping
        {
            internal static object? HandleShoppingChoice(PlayerChar player, ItemCategory selectedCategory)
            {
                char playerRank = (char)player.HeroRank;

                switch(selectedCategory)
                {
                    case ItemCategory.Weapons:
                        return BuyWeapon(playerRank);

                    case ItemCategory.Protection:
                        return BuyProtection(playerRank);

                    case ItemCategory.Healing:
                        return BuyHealing(playerRank);

                    default:
                        Console.WriteLine("Input not valid, please try again");
                        break;
                }

                return null;
            }
            internal static Sword? BuyWeapon(char playerRank)
            {
                if(playerRank.Equals('C'))
                {
                   
                }
                return null;
            }
            internal static PlayerProtection? BuyProtection(char playerRank)
            {
                Console.WriteLine("Test");
                return null;
            }
            internal static HealingItems? BuyHealing(char playerRank)
            {
                Console.WriteLine("Test");
                return null;
            }
        }
    }
}