using System;
using GameCharacters;
using Equipment;
using GameFunctions;

namespace TurnBasedGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //TitleScreen.GameTitleScreen();
            Sword equipedSword = new Sword(0);
            Shield equipedShield = new Shield(0);
            Armor equipedArmor = new Armor(0);
            PlayerChar player = new PlayerChar("Alex", equipedSword, equipedShield, equipedArmor);
            PlayerTurn.Actions(player);
        }
    }
}