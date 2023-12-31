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
        internal static object Shop(PlayerChar playerRank)
        {
            Console.Clear();
            Console.WriteLine("What are you buying?\n");
            Thread.Sleep(1000);
            Console.WriteLine("1- Weapons\n2- Shield/Armor\n3- Healing Items");
            Console.Write(": ");
            string? input = Console.ReadLine();
            
            if(!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Input cannot be void or empty, press ENTER to try again");
            }
            else
            {
                ItemCategory selectedCategory = (ItemCategory)choice;
                return Shopping.HandleShoppingChoice(playerRank, selectedCategory);
            }

            return null;
        }
        internal class Shopping
        {
            internal static object HandleShoppingChoice(PlayerChar playerRank, ItemCategory selectedCategory)
            {
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
            internal static PlayerOffense BuyWeapon(PlayerChar playerRank)
            {
                return null;
            }
            internal static PlayerProtection BuyProtection(PlayerChar playerRank)
            {
                return null;
            }
            internal static HealingItems BuyHealing(PlayerChar playerRank)
            {
                return null;
            }
        }
    }
}