using System;
using GameCharacters;

namespace GameFunctions
{
    internal class MonsterFactory
    {
        private static Random randomNum = new Random();

        internal static Monster CreateMonster(int floorNum)
        {
            int monsterNum = randomNum.Next(1, 6);

            switch(floorNum)
            {
                case 1:
                    return MonsterCreator.CreateEasyLvl(monsterNum);
                
                case 2:
                    return MonsterCreator.CreateMediumLvl(monsterNum);
                
                default:
                    throw new ArgumentException("Invalid floor");
            }
        }
    }
    internal static class MonsterCreator
    {
        internal static Monster CreateEasyLvl(int monster)
        {
            switch(monster)
            {
                case 1:
                    return new MonstersFloor01(1);

                case 2:
                    return new MonstersFloor01(2);
                
                case 3:
                    return new MonstersFloor01(3);
                
                case 4:
                    return new MonstersFloor01(4);

                case 5:
                    return new MonstersFloor01(5);
                
                default:
                    throw new ArgumentException("Invalid random number for easy monsters");
            }
        }
        internal static Monster CreateMediumLvl(int monster)
        {
            switch(monster)
            {
                case 1:
                    return new MonstersFloor02(1);

                case 2:
                    return new MonstersFloor02(2);
                
                case 3:
                    return new MonstersFloor02(3);
                
                case 4:
                    return new MonstersFloor02(4);

                case 5:
                    return new MonstersFloor02(5);
                
                default:
                    throw new ArgumentException("Invalid random number for easy monsters");
            }
        }
    }
}