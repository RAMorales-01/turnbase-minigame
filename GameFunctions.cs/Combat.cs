using System;
using GameCharacters;
using Equipment;

namespace GameFunctions
{
    internal static class Combat
    {
        internal static void StartCombat()
        {

        }
        private static int AttackPlayerTurn(Hero player, Sword currentSword)
        {
            int totalDmg = 0;

            if(currentSword.HasExtraDmg == true)
            {
                totalDmg = player.DefaultOffense + currentSword.Damage + currentSword.PlusDamage;
            }
            else
            {
                totalDmg = player.DefaultOffense + currentSword.Damage;
            }

            return totalDmg;
        }
        private static int DefensePlayerTurn(Hero player, Shield currentShield, Armor currentArmor)
        {
            int totalDef = player.DefaultDefense;
            int shieldPlus = currentShield.Defense + currentShield.PlusDefense;
            int armorPlus = currentArmor.Defense + currentArmor.PlusDefense;

            if(currentShield.HasExtraDef == true || currentArmor.HasExtraDef == true)
            {
                if(currentShield.HasExtraDef == true && currentArmor.HasExtraDef == true)
                {
                    return totalDef += (shieldPlus + armorPlus);
                }
                else if(currentShield.HasExtraDef == true && currentArmor.HasExtraDef == false)
                {
                    return totalDef += (shieldPlus + currentArmor.Defense);
                }
                else
                {
                    return totalDef += (currentShield.Defense + armorPlus); 
                }
            }
            else
            {
                return totalDef += currentShield.Defense + currentArmor.Defense;
            }
        }

        // Next is the monster and bosses logic
    } 
}