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
        internal static void Shop(PlayerChar player)
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
                Shopping.HandleShoppingChoice(player, selectedCategory);
            }
        }
        internal class Shopping
        {
            internal static void HandleShoppingChoice(PlayerChar player, ItemCategory selectedCategory)
            {
                switch(selectedCategory)
                {
                    case ItemCategory.Weapons:
                        BuyWeapon(player);
                        break;

                    case ItemCategory.Protection:
                        BuyProtection(player);
                        break;

                    case ItemCategory.Healing:
                        BuyHealing();
                        break;

                    default:
                        Console.WriteLine("Input not valid, please try again");
                        break;
                }
            }
            internal static void BuyWeapon(PlayerChar player)
            {
                Console.Clear();
                Console.WriteLine("With your current Rank you are able to buy this weapon:\n");

                switch(player.HeroRank)
                {
                    case Rank.C:
                        Sword rankC = new Sword(1);
                        SwordInfo(rankC);
                        break;
                    
                    case Rank.B:
                        Sword rankB = new Sword(2);
                        SwordInfo(rankB);
                        break;
                    
                    case Rank.A:
                        Sword rankA = new Sword(3);
                        SwordInfo(rankA);
                        break;
                    
                    case Rank.S:
                        Sword rankS = new Sword(4);
                        SwordInfo(rankS);
                        break;
                    
                    case Rank.SS:
                        Sword rankSS = new Sword(5);
                        SwordInfo(rankSS);
                        break;
                }
            }
            internal static void BuyProtection(PlayerChar player)
            {
                
            }
            internal static void BuyHealing()
            {
                Console.WriteLine("These are 3 types of healing potions currently availables:\n");
                Console.WriteLine("1- Lesser Potion\n2- Medium Potion\n3- High Potion");
                Console.Write(": ");
                string? input = Console.ReadLine();
            
                if(!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Input not valid, you must choose only the presented options");
                }
                else
                {
                    switch(choice)
                    {
                        case 1:
                            HealingItems lowPotion = new HealingItems(1);
                            Console.WriteLine($"{lowPotion.Name}\n");
                            PotionInfo(lowPotion);
                            break;
                        
                        case 2:
                            HealingItems medPotion = new HealingItems(2);
                            Console.WriteLine($"{medPotion.Name}\n");
                            PotionInfo(medPotion);
                            break;
                        
                        case 3:
                            HealingItems highPotion = new HealingItems(3);
                            Console.WriteLine($"{highPotion.Name}\n");
                            PotionInfo(highPotion);
                            break;
                    }
                }
            }
            private static void SwordInfo(Sword currentRankSword)
            {
                Console.WriteLine($"{currentRankSword.Name}\n");
                Console.WriteLine($"Info: {currentRankSword.EquipmentInfo}");
                Console.WriteLine($"Power: {currentRankSword.Damage}");
                Console.WriteLine($"Weight: {currentRankSword.EquipmentWeight} kgs");
                Console.WriteLine($"Price: {currentRankSword.EquipmentPrice} gold");
            }
            private static void PotionInfo(HealingItems potion)
            {
                Console.WriteLine($"Info: {potion.ItemDescription}");
                Console.WriteLine($"Price: {potion.ItemPrice} gold");
            }
            
            private static bool BuySword(PlayerChar player, Sword currentRankSword)
            {
                string? input = string.Empty;

                do
                {
                    Console.WriteLine("Do you wish to buy it?");
                    Console.Write("Y/N: ");
                    input = Console.ReadLine()?.ToUpper();

                    if(string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("\nInput cannot be void or empty, please try again\n");
                    }
                    else if(input != "Y" || input != "N")
                    {
                        Console.WriteLine("\nInput not valid, must be Y or N only, please try again\n");
                    }
                    else
                    {
                        break;
                    } 
                }while(true);

                if(input == "Y")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } 
        }
    }
}