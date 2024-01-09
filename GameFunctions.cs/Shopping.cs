using System;
using System.Threading;
using Equipment;
using GameCharacters;
using RankLevels;

namespace GameFunctions
{
    #region Global enmus
    public enum ItemCategory
    {
        Weapons = 1,
        Protection = 2,
        Healing = 3
    }
    public enum ProtectionCategory
    {
        Shield = 1,
        Armor = 2
    }
    #endregion

    #region Shop class
    internal class EquipmentItemStore
    {
        /// <summary>
        /// Input function for category selection of the store. 
        /// </summary>
        /// <param name="player"></param>
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

        #region Selection 
        internal class Shopping
        {
            /// <summary>
            /// Handles each method for the different equipment the player can buy in the store
            /// after the player has selected the category in the previous Shop method.
            /// </summary>
            /// <param name="player"></param>
            /// <param name="selectedCategory"></param>
            internal static void HandleShoppingChoice(PlayerChar player, ItemCategory selectedCategory)
            {
                switch(selectedCategory)
                {
                    case ItemCategory.Weapons:
                        BuySword(player);
                        break;

                    case ItemCategory.Protection:
                        SelectProtection(player);
                        break;

                    case ItemCategory.Healing:
                        BuyHealing();
                        break;

                    default:
                        Console.WriteLine("Input not valid, please try again");
                        break;
                }
            }

            /// <summary>
            /// Input function for protection category selection of the store. 
            /// </summary>
            /// <param name="player"></param>
            internal static void SelectProtection(PlayerChar player)
            {
                Console.Clear();
                Console.WriteLine("What are you buying?\n");
                Console.WriteLine("\n1- Shield\n2- Armor");
                string? input = Console.ReadLine();

                if(!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Input not valid, you must choose only the presented options");
                }
                else
                {
                    ProtectionCategory selectedCategory = (ProtectionCategory)choice;
                    Shopping.HandleProtectionChoice(player, selectedCategory);
                }
            }

            /// <summary>
            /// Handles the 2 methods for the choices of protection equipment the player can buy in the store.
            /// </summary>
            /// <param name="player"></param>
            /// <param name="selectedCategory"></param>
            private static void HandleProtectionChoice(PlayerChar player, ProtectionCategory selectedCategory)
            {
                switch(selectedCategory)
                {
                    case ProtectionCategory.Shield:
                        BuyShield(player);
                        break;

                    case ProtectionCategory.Armor:
                        BuyArmor(player);
                        break;
                }
            }
            #endregion
            
            #region Buy equipment methods
            /// <summary>
            /// Handles the different Sword objects the player can buy and use in the game, takes the player
            /// instance as parameter and checks the player hero rank to match wich sword the player can currently 
            /// access, for example if the player hero rank is "A" then he/she can access to the Sword rankA instance.
            /// </summary>
            /// <param name="player"></param>
            internal static void BuySword(PlayerChar player)
            {
                bool buyEquipment; // Stores the return from the BuyConfirmation method
                int costEquipment = 0; // Stores the equipment price, if BuyConfirmation returns true subtracts cost from player current gold

                Console.Clear();
                Console.WriteLine("With your current Rank you are able to buy this weapon:\n");

                switch(player.HeroRank)
                {
                    case Rank.C:
                        Sword rankC = new Sword(1);
                        costEquipment = rankC.EquipmentPrice;
                        SwordInfo(rankC);
                        buyEquipment = BuyConfirmation(player, costEquipment);
                        if(buyEquipment == true)
                        {
                            player.EquipSword(rankC);
                            player.Gold -= costEquipment;
                        }
                        break;
                    
                    case Rank.B:
                        Sword rankB = new Sword(2);
                        costEquipment = rankB.EquipmentPrice;
                        SwordInfo(rankB);
                        buyEquipment = BuyConfirmation(player, costEquipment);
                        if(buyEquipment == true)
                        {
                            player.EquipSword(rankB);
                            player.Gold -= costEquipment;
                        }
                        break;
                    
                    case Rank.A:
                        Sword rankA = new Sword(3);
                        costEquipment = rankA.EquipmentPrice;
                        SwordInfo(rankA);
                        buyEquipment = BuyConfirmation(player, costEquipment);
                        if(buyEquipment == true)
                        {
                            player.EquipSword(rankA);
                            player.Gold -= costEquipment;
                        }
                        break;
                    
                    case Rank.S:
                        Sword rankS = new Sword(4);
                        costEquipment = rankS.EquipmentPrice;
                        SwordInfo(rankS);
                        buyEquipment = BuyConfirmation(player, costEquipment);
                        if(buyEquipment == true)
                        {
                            player.EquipSword(rankS);
                            player.Gold -= costEquipment;
                        }
                        break;
                    
                    case Rank.SS:
                        Sword rankSS = new Sword(5);
                        costEquipment = rankSS.EquipmentPrice;
                        SwordInfo(rankSS);
                        buyEquipment = BuyConfirmation(player, costEquipment);
                        if(buyEquipment == true)
                        {
                            player.EquipSword(rankSS);
                            player.Gold -= costEquipment;
                        }
                        break;
                }
            }

            internal static void BuyShield(PlayerChar player)
            {
            
            }
            internal static void BuyArmor(PlayerChar player)
            {

            }

            /// <summary>
            /// Handles the different Healing potion objects the player can buy and use in the game, doesn't need
            /// any check and the player can access to all the type of potions at any time.
            /// </summary>
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
            #endregion

            #region Equipment information display methods
            /// <summary>
            /// Displays information of the current Sword object the player can access during the BuySword method. 
            /// </summary>
            /// <param name="currentRankSword"></param>
            private static void SwordInfo(Sword currentRankSword)
            {
                Console.WriteLine($"\t\t\t{currentRankSword.Name}\n");
                Console.WriteLine($"\"{currentRankSword.EquipmentInfo}\"");
                Console.WriteLine($"\nDamage: {currentRankSword.Damage}");
                Console.WriteLine($"Weight: {currentRankSword.EquipmentWeight} kgs");
                Console.WriteLine($"Price: {currentRankSword.EquipmentPrice} gold");
            }

            /// <summary>
            /// Displays information of the current Shield object the player can access during the BuyShield method.
            /// </summary>
            /// <param name="currentRankShield"></param>
            private static void ShieldInfo(Shield currentRankShield)
            {
                Console.WriteLine($"\t\t\t{currentRankShield.Name}\n");
                Console.WriteLine($"\"{currentRankShield.EquipmentInfo}\"");
                Console.WriteLine($"\nDefense: {currentRankShield.Defense}");
                Console.WriteLine($"Weight: {currentRankShield.EquipmentWeight} kgs");
                Console.WriteLine($"Price: {currentRankShield.EquipmentPrice} gold");
            }

            /// <summary>
            /// Displays information of the current Armor object the player can access during the BuyArmor method.
            /// </summary>
            /// <param name="currentRankShield"></param>
            private static void ArmorInfo(Shield currentRankArmor)
            {
                Console.WriteLine($"\t\t\t{currentRankArmor.Name}\n");
                Console.WriteLine($"\"{currentRankArmor.EquipmentInfo}\"");
                Console.WriteLine($"\nDefense: {currentRankArmor.Defense}");
                Console.WriteLine($"Weight: {currentRankArmor.EquipmentWeight} kgs");
                Console.WriteLine($"Price: {currentRankArmor.EquipmentPrice} gold");
            }

            /// <summary>
            /// Displays information of the Healing potions the player can access in the BuyHealing method. 
            /// </summary>
            /// <param name="potion"></param>
            private static void PotionInfo(HealingItems potion)
            {
                Console.WriteLine($"Info: {potion.ItemDescription}");
                Console.WriteLine($"Price: {potion.ItemPrice} gold");
            }
            #endregion
            
            /// <summary>
            /// Handles the confirmation checks for buying equipment in the store.
            /// </summary>
            /// <param name="player"></param>
            /// <param name="costEquipment"></param>
            /// <returns>boolean</returns>
            private static bool BuyConfirmation(PlayerChar player, int costEquipment)
            {
                string? input = string.Empty;

                do
                {
                    Console.WriteLine("\nDo you wish to buy it?");
                    Console.Write("Y/N: ");
                    input = Console.ReadLine()?.ToUpper();

                    if(string.IsNullOrEmpty(input))
                    {
                        Console.WriteLine("\nInput cannot be void or empty, please try again\n");
                    }
                    else if(input.Equals("Y") || input.Equals("N"))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\nInput not valid, must be Y or N only, please try again\n");
                    } 
                }while(true);

                if(input == "Y" && player.Gold >= costEquipment)
                {
                    return true;
                }
                else if(input == "Y" && player.Gold < costEquipment)
                {
                    Console.WriteLine("\nSorry you don't have enough gold\n");
                    return false;
                }
                else
                {
                    return false;
                }
            } 
        }
    }
    #endregion
}