using System;

namespace GameCharacters
{
    abstract class Monster : IMonster
    {
        private int _monsterId;
        private string _name = string.Empty;
        private int _hp;
        private int _defaultDefense;
        private int _defaultOffense;
        private int _goldDrop;

        public int MonsterID { get; protected set; }
        public string Name { get; protected set; } = string.Empty;
        public int HP { get; protected set; }
        public int DefaultOffense { get; protected set; }
        public int DefaultDefense { get; protected set; }
        public int GoldDrop { get; protected set; }
    }
    internal class MonstersFloor01 : Monster
    {
        public MonstersFloor01(int invokeMonsterNum)
        {
            switch(invokeMonsterNum)
            {
                case 1:
                    this.MonsterID = 1;
                    this.Name = "Dire Wolf";
                    this.HP = 50;
                    this.DefaultOffense = 10;
                    this.DefaultDefense = 5;
                    this.GoldDrop = 50;
                    break;
                
                case 2:
                    this.MonsterID = 2;
                    this.Name = "Harpy";
                    this.HP = 80;
                    this.DefaultOffense = 12;
                    this.DefaultDefense = 8;
                    this.GoldDrop = 50;
                    break;
                
                case 3:
                    this.MonsterID = 3;
                    this.Name = "Slime";
                    this.HP = 40;
                    this.DefaultOffense = 5;
                    this.DefaultDefense = 5;
                    this.GoldDrop = 25;
                    break; 
                
                case 4:
                    this.MonsterID = 7;
                    this.Name = "Goblin";
                    this.HP = 80;
                    this.DefaultOffense = 11;
                    this.DefaultDefense = 10;
                    this.GoldDrop = 100;
                    break;
                
                case 5:
                    this.MonsterID = 8;
                    this.Name = "Kobold";
                    this.HP = 100;
                    this.DefaultOffense = 12;
                    this.DefaultDefense = 14;
                    this.GoldDrop = 110;
                    break;
            }
        }
    }
    internal class MonstersFloor02 : Monster
    {
        public MonstersFloor02(int invokeMonsterNum)
        {
            switch(invokeMonsterNum)
            {
                case 1:
                    this.MonsterID = 4;
                    this.Name = "Savage Wolf";
                    this.HP = 120;
                    this.DefaultOffense = 13;
                    this.DefaultDefense = 8;
                    this.GoldDrop = 60;
                    break;
                    
                case 2:
                    this.MonsterID = 5;
                    this.Name = "Gargoyle";
                    this.HP = 140;
                    this.DefaultOffense = 14;
                    this.DefaultDefense = 10;
                    this.GoldDrop = 60;
                    break;
                    
                case 3:
                    this.MonsterID = 6;
                    this.Name = "Steel Slime";
                    this.HP = 80;
                    this.DefaultOffense = 8;
                    this.DefaultDefense = 25;
                    this.GoldDrop = 250;
                    break;
                    
                case 4:
                    this.MonsterID = 9;
                    this.Name = "Chief Goblin";
                    this.HP = 110;
                    this.DefaultOffense = 10;
                    this.DefaultDefense = 13;
                    this.GoldDrop = 120;
                    break;
                    
                case 5:
                    this.MonsterID = 10;
                    this.Name = "Captain Kobold";
                    this.HP = 150;
                    this.DefaultOffense = 10;
                    this.DefaultDefense = 12;
                    this.GoldDrop = 150;
                    break;
            }
        }
    }
}