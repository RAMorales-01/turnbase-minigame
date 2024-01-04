using System;
using GameCharacters;
using Equipment;
using RankLevels;
using GameFunctions;

namespace TurnBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TitleScreen.GameTitleScreen();
            Sword currentSword = new Sword(0);
            Shield currentShield = new Shield(0);
            Armor currentArmor = new Armor(0);
            PlayerChar test = new PlayerChar("Alex", currentSword, currentShield, currentArmor);
            //Console.WriteLine($"TEST: {test.HeroRank}");
            EquipmentItemStore.Shop(test);
            
        }
    }
}