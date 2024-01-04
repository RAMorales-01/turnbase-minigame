using System;
using System.Threading;
using Equipment;
using GameCharacters;
using RankLevels;

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
                switch(selectedCategory)
                {
                    case ItemCategory.Weapons:
                        return BuyWeapon(player);

                    case ItemCategory.Protection:
                        return BuyProtection(player);

                    case ItemCategory.Healing:
                        return BuyHealing(player);

                    default:
                        Console.WriteLine("Input not valid, please try again");
                        break;
                }

                return null;
            }
            internal static Sword? BuyWeapon(PlayerChar player)
            {
                Console.Clear();
                Console.WriteLine("With your current Rank you are able to buy this sword: \n");

                switch(player.HeroRank)
                {
                    case Rank.C:
                        Sword rankC = new Sword(1);
                        SwordInfo(rankC);
                        return rankC;
                    
                    case Rank.B:
                        Sword rankB = new Sword(2);
                        SwordInfo(rankB);
                        return rankB;
                    
                    case Rank.A:
                        Sword rankA = new Sword(3);
                        SwordInfo(rankA);
                        return rankA;
                    
                    case Rank.S:
                        Sword rankS = new Sword(4);
                        SwordInfo(rankS);
                        return rankS;
                    
                    case Rank.SS:
                        Sword rankSS = new Sword(5);
                        SwordInfo(rankSS);
                        return rankSS;

                    default:
                        return null;
                }
            }
            internal static PlayerProtection? BuyProtection(PlayerChar player)
            {
                return null;
            }
            internal static HealingItems? BuyHealing(PlayerChar player)
            {
                Console.WriteLine("These are 3 types of healing potions currently availables");
                return null;
            }
            private static void SwordInfo(Sword currentRankSword)
            {
                Console.WriteLine($"{currentRankSword.Name}\n");
                Console.WriteLine($"Info: {currentRankSword.EquipmentInfo}");
                Console.WriteLine($"Power: {currentRankSword.Damage}");
                Console.WriteLine($"Weight: {currentRankSword.EquipmentWeight} kgs");
                Console.WriteLine($"Price: {currentRankSword.EquipmentPrice} gold");
            }
        }
    }
}