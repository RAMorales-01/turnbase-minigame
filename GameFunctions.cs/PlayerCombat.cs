using System;
using GameCharacters;
using Equipment;

namespace GameFunctions
{
    internal static class PlayerTurn
    {
        /// <summary>
        /// Main function for the actions the player can take during his/her turn.
        /// </summary>
        /// <param name="hero"></param>
        /// <returns>int value for either damage or defense</returns>
        internal static int Actions(PlayerChar hero)
        {
            do
            {
                Console.WriteLine($"It's {hero.Name} turn");
                Console.WriteLine("1- Attack\n2- Defend");
                bool isInterger = int.TryParse(Console.ReadLine(), out int playerInput);

                if(playerInput == 1)
                {
                    return AttackPlayerTurn(hero, hero.Sword!);
                }
                else if(playerInput == 2)
                {
                    return DefensePlayerTurn(hero, hero.Shield!, hero.Armor!);
                }
                else 
                {
                    Console.WriteLine("Input not valid");
                }
            }while(true);
        }

        /// <summary>
        /// Calculates the damage the player will do to the enemy during his/her
        /// turn.
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="equipedSword"></param>
        /// <returns>int value for damage</returns>
        private static int AttackPlayerTurn(PlayerChar hero, Sword equipedSword)
        {
            int totalDmg = hero.DefaultOffense;

            if(equipedSword.HasExtraDmg == true)
                totalDmg += (equipedSword.Damage + equipedSword.PlusDamage);
            
            else
                totalDmg += equipedSword.Damage;

            return totalDmg;
        }

        /// <summary>
        /// Returns the damage reduction total value after the helper method 
        /// calculations.
        /// </summary>
        /// <param name="hero"></param>
        /// <param name="equipedShield"></param>
        /// <param name="equipedArmor"></param>
        /// <returns>int value for damage reduction</returns>
        private static int DefensePlayerTurn(PlayerChar hero, Shield equipedShield, Armor equipedArmor)
        {
            int baseDefense = hero.DefaultDefense;
            int shieldDefense = CalculateEquipmentDefense(equipedShield);
            int armorDefense = CalculateEquipmentDefense(equipedArmor);

            return baseDefense + shieldDefense + armorDefense;
        }

        /// <summary>
        /// Helper method to calculate the damage reduction the player take from the  
        /// monster during its turn.
        /// </summary>
        /// <param name="equipment"></param>
        /// <returns>int value for damage reduction</returns>
        private static int CalculateEquipmentDefense(PlayerProtection equipment)
        {
            int baseDefense = equipment.Defense;
            int extraDefense = equipment.HasExtraDef ? equipment.PlusDefense : 0;

            return baseDefense + extraDefense;
        }
    } 
}