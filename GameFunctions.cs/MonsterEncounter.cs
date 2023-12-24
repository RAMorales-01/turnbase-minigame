using System;
using GameCharacters;

namespace GameFunctions
{
    internal class MonsterFactory
    {
        private static Random randomNum = new Random();

        internal static Monster CreateMonster(int difficulty)
        {
            int monsterNum = randomNum.Next(1, 6);

            switch(difficulty)
            {
                case 1:
                    return MonsterCreator.CreateEasyLvl(monsterNum);
                
                case 2:
                    return MonsterCreator.CreateMediumLvl(monsterNum);
                
                default:
                    throw new ArgumentException("Invalid Difficuly Level");
            }
        }
    }
    internal static class MonsterCreator
    {
        internal static Monster CreateEasyLvl(int monsterNum)
        {
            switch(monsterNum)
            {
                case 1:
                    return new MonstersEasyLvl(1);

                case 2:
                    return new MonstersEasyLvl(2);
                
                case 3:
                    return new MonstersEasyLvl(3);
                
                case 4:
                    return new MonstersEasyLvl(4);

                case 5:
                    return new MonstersEasyLvl(5);
                
                default:
                    throw new ArgumentException("Invalid random number for easy monsters");
            }
        }
        internal static Monster CreateMediumLvl(int monsterNum)
        {
            switch(monsterNum)
            {
                case 1:
                    return new MonstersMediumLvl(1);

                case 2:
                    return new MonstersMediumLvl(2);
                
                case 3:
                    return new MonstersMediumLvl(3);
                
                case 4:
                    return new MonstersMediumLvl(4);

                case 5:
                    return new MonstersMediumLvl(5);
                
                default:
                    throw new ArgumentException("Invalid random number for easy monsters");
            }
        }
    }
}