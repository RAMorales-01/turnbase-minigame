using System;
using GameCharacters;
using Equipment;

namespace GameFunctions
{
    internal static class PlayerTurn
    {
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
        private static int AttackPlayerTurn(PlayerChar hero, Sword equipedSword)
        {
            int totalDmg = hero.DefaultOffense;

            if(equipedSword.HasExtraDmg == true)
                totalDmg += (equipedSword.Damage + equipedSword.PlusDamage);
            
            else
                totalDmg += equipedSword.Damage;

            return totalDmg;
        }
        private static int DefensePlayerTurn(PlayerChar hero, Shield equipedShield, Armor equipedArmor)
        {
            int baseDefense = hero.DefaultDefense;
            int shieldDefense = CalculateEquipmentDefense(equipedShield);
            int armorDefense = CalculateEquipmentDefense(equipedArmor);

            return baseDefense + shieldDefense + armorDefense;
        }
        private static int CalculateEquipmentDefense(PlayerProtection equipment)
        {
            int baseDefense = equipment.Defense;
            int extraDefense = equipment.HasExtraDef ? equipment.PlusDefense : 0;

            return baseDefense + extraDefense;
        }
    } 
}