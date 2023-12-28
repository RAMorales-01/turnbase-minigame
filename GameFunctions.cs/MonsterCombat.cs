using System;
using GameCharacters;

namespace GameFunctions
{
    internal static class FloorEnemyTurn
    {
        private static Random randomNum = new Random(); 
        enum EnemyActions // Determines current posible actions the monster can take
        {
            Attack = 1,
            Defend = 2
        }

        /// <summary>
        /// Main function for the current floor monster action by using the random class instance,
        /// the current floor monster can only take an action of attack or defend.
        /// </summary>
        /// <param name="currentEnemy"></param>
        /// <returns>int for damage or int for defense</returns>
        internal static int MonsterAction(Monster currentEnemy)
        {
            EnemyActions enemyAction = (EnemyActions)randomNum.Next(1, 3);

            if(enemyAction == EnemyActions.Attack)
            {
                Console.WriteLine($"{currentEnemy.Name} attacks!");
                return EnemyAttack(currentEnemy);
            }
            else
            {
                Console.WriteLine($"{currentEnemy.Name} defends from your attack!");
                return EnemyDefense(currentEnemy);
            }
        }

        /// <summary>
        /// Returns the damage value of the current enemy instance
        /// </summary>
        /// <param name="currentEnemy"></param>
        /// <returns>int damage value of current enemy</returns>
        private static int EnemyAttack(Monster currentEnemy)
        {
            int totalDmg = currentEnemy.DefaultOffense;

            return totalDmg;
        }

        /// <summary>
        /// Returns the defense value of the current enemy instance
        /// </summary>
        /// <param name="currentEnemy"></param>
        /// <returns>int defense value of current enemy</returns>
        private static int EnemyDefense(Monster currentEnemy)
        {
            int totalDef = currentEnemy.DefaultDefense;

            return totalDef;
        }
    }
}