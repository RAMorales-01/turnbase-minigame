using System;

namespace GameCharacters
{
    abstract class Monster : IMonster
    {
        #region Monster class Properties
        public enum Rank
        {
            C,
            B,
            A,
            S,
            Boss
        }
        public string Name { get; protected set; } = string.Empty;
        public int HP { get; protected set; }
        public int DefaultOffense { get; protected set; }
        public int DefaultDefense { get; protected set; }
        public Rank MonsterRank { get; protected set; }
        public int GoldDrop { get; protected set; }
        #endregion
    }
    internal class MonstersFloor01 : Monster
    {
        #region Floor 1 Monsters
        public MonstersFloor01(int monster)
        {
            switch(monster)
            {
                case 1:
                    this.Name = "Wolf";
                    this.HP = 40;
                    this.DefaultOffense = 6;
                    this.DefaultDefense = 5;
                    this.MonsterRank = Rank.C;
                    this.GoldDrop = 50;
                    break;
                
                case 2:
                    this.Name = "Harpy";
                    this.HP = 50;
                    this.DefaultOffense = 8;
                    this.DefaultDefense = 5;
                    this.MonsterRank = Rank.C;
                    this.GoldDrop = 50;
                    break;
                
                case 3:
                    this.Name = "Slime";
                    this.HP = 30;
                    this.DefaultOffense = 2;
                    this.DefaultDefense = 2;
                    this.MonsterRank = Rank.C;
                    this.GoldDrop = 10;
                    break; 
                
                case 4:
                    this.Name = "Goblin";
                    this.HP = 80;
                    this.DefaultOffense = 10;
                    this.DefaultDefense = 10;
                    this.MonsterRank = Rank.C;
                    this.GoldDrop = 100;
                    break;
                
                case 5:
                    this.Name = "Kobold";
                    this.HP = 100;
                    this.DefaultOffense = 11;
                    this.DefaultDefense = 15;
                    this.MonsterRank = Rank.C;
                    this.GoldDrop = 150;
                    break;
            }
        }
        #endregion
    }
    internal class MonstersFloor02 : Monster
    {
        #region Floor 2 Monsters
        public MonstersFloor02(int monster)
        {
            switch(monster)
            {
                case 1:
                    this.Name = "Dire Wolf";
                    this.HP = 80;
                    this.DefaultOffense = 8;
                    this.DefaultDefense = 8;
                    this.MonsterRank = Rank.B;
                    this.GoldDrop = 60;
                    break;
                    
                case 2:
                    this.Name = "Gargoyle";
                    this.HP = 100;
                    this.DefaultOffense = 10;
                    this.DefaultDefense = 8;
                    this.MonsterRank = Rank.B;
                    this.GoldDrop = 60;
                    break;
                    
                case 3:
                    this.Name = "Steel Slime";
                    this.HP = 60;
                    this.DefaultOffense = 6;
                    this.DefaultDefense = 25;
                    this.MonsterRank = Rank.B;
                    this.GoldDrop = 300;
                    break;
                    
                case 4:
                    this.Name = "Goblin Chief";
                    this.HP = 160;
                    this.DefaultOffense = 11;
                    this.DefaultDefense = 13;
                    this.MonsterRank = Rank.B;
                    this.GoldDrop = 120;
                    break;
                    
                case 5:
                    this.Name = "Kobold Chief";
                    this.HP = 180;
                    this.DefaultOffense = 11;
                    this.DefaultDefense = 15;
                    this.MonsterRank = Rank.B;
                    this.GoldDrop = 140;
                    break;
            }
        }
        #endregion
    }
    internal class MonstersFloorBoss : Monster
    {
        #region Boss Monsters
        public MonstersFloorBoss(int boss)
        {
            switch(boss)
            {
                case 1:
                    this.Name = "Goblin Champion";
                    this.HP = 300;
                    this.DefaultOffense = 12;
                    this.DefaultDefense = 16;
                    this.MonsterRank = Rank.Boss;
                    this.GoldDrop = 1000;
                    break;
            }
        }
        #endregion
    }
}