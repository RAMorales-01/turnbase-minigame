using System; 

namespace GameCharacters
{
    class Player : IPlayerCharacter
    {
        private string _name = string.Empty;
        private int _hp;
        private int _defaultOffense;
        private int _defaultDefense;
        private int _initialGold;

        public string Name 
        { 
            get { return _name; } 
            set { _name = value; } 
        }
        public int HP 
        {   get { return _hp; } 
            private set { _hp = value; } 
        }
        public int DefaultOffense 
        {   get { return _defaultOffense; }
            private set { _defaultOffense = value; } 
        }
        public int DefaultDefense 
        {   get { return _defaultDefense; } 
            private set { _defaultDefense = value; } 
        }
        public int InitialGold
        {
            get { return _initialGold; }
            internal set { _initialGold = value; }
        }

        public Player(string name)
        {
            this.Name = name;
            this.HP = 100;
            this.DefaultOffense = 5;
            this.DefaultDefense = 5;
            this.InitialGold = 200;
        }

        public int AttackPhase(int defPow, int weaponPow)
        {
            int sumDamage = 0;

            return sumDamage = defPow + weaponPow;
        }
        public int DefensePhase(int defDef, int shieldDef, int armorDef)
        {
            int sumDefense = 0;

            return sumDefense = defDef + shieldDef + armorDef;
        }
    }
}