using System;
using GameCharacters;

namespace GameFunctions
{
    internal class MonsterFactory
    {
        #region Monster creation main function
        private static Random randomNum = new Random();
        
        /// <summary>
        /// Main function for the creation of monsters divided by floor.
        /// </summary>
        /// <param name="floorNum"></param>
        /// <returns>Monster instance</returns>
        /// <exception cref="ArgumentException"></exception>
        internal static Monster CreateMonster(int floorNum)
        {
            int monsterNum = randomNum.Next(1, 6);

            switch(floorNum)
            {
                case 1:
                    return MonsterCreator.CreateMonsterFloor1(monsterNum);
                
                case 2:
                    return MonsterCreator.CreateMonsterFloor2(monsterNum);
                
                default:
                    throw new ArgumentException("Invalid floor");
            }
        }
        #endregion
    }
    internal static class MonsterCreator
    {
        #region Floor 1 monster creation
        /// <summary>
        /// Creates monster instance for floor 1 of the tower.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns>Monster instance</returns>
        /// <exception cref="ArgumentException"></exception>
        internal static Monster CreateMonsterFloor1(int monster)
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
        #endregion

        #region Floor 2 monster creation
        /// <summary>
        /// Creates monster instance for floor 2 of the tower.
        /// </summary>
        /// <param name="monster"></param>
        /// <returns>Monster instance</returns>
        /// <exception cref="ArgumentException"></exception>
        internal static Monster CreateMonsterFloor2(int monster)
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
        #endregion
    }
}