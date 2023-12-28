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
            var currentMonster = MonsterFactory.CreateMonster(1);
            FloorEnemyTurn.MonsterAction(currentMonster);
        }
    }
}