using System;
using Equipment;
using RankLevels;

namespace GameCharacters
{
    class PlayerChar : ICharacter
    {
        #region Player character properties
        private const int DefaultOffenseValue = 5;
        private const int DefaultDefenseValue = 5;
        private const int InitialGold = 1000;

        public string Name { get; internal set; }
        public int HP { get; internal set; } = 100;
        public int DefaultOffense { get; private set; } = DefaultOffenseValue;
        public int DefaultDefense { get; private set; } = DefaultDefenseValue;
        public Rank HeroRank { get; internal set; } = Rank.C;
        public int Gold { get; internal set; } = InitialGold;

        public Sword? Sword { get; private set; } = null;
        public Shield? Shield { get; private set; } = null; 
        public Armor? Armor { get; private set; } = null;
        #endregion

        #region Player character constructor
        public PlayerChar(string name, Sword initialSword, Shield initialShield, Armor initialArmor)
        {
            this.Name = name;
            this.Sword = initialSword;
            this.Shield = initialShield;
            this.Armor = initialArmor;
        }

        #endregion

        #region Player methods
        internal void EquipSword(Sword newSword)
        {
            if(newSword.EquipmentRank <= HeroRank)
            {
                Sword = newSword;
                Console.WriteLine($"{Name} has equiped the {newSword.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} cannot equip the {newSword.Name}");
                Console.WriteLine($"{Name} rank is {HeroRank}, you need a minimum rank of {newSword.EquipmentRank} to equip it");
            }
        }
        internal void EquipShield(Shield newShield)
        {
            if(newShield.EquipmentRank <= HeroRank)
            {
                Shield = newShield;
                Console.WriteLine($"{Name} has equiped the {newShield.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} cannot equip the {newShield.Name}");
                Console.WriteLine($"{Name} rank is {HeroRank}, you need a minimum rank of {newShield.EquipmentRank} to equip it");
            }
        }
        internal void EquipArmor(Armor newArmor)
        {
            if(newArmor.EquipmentRank <= HeroRank)
            {
                Armor = newArmor;
                Console.WriteLine($"{Name} has equiped the {newArmor.Name}");
            }
            else
            {
                Console.WriteLine($"{Name} cannot equip the {newArmor.Name}");
                Console.WriteLine($"{Name} rank is {HeroRank}, you need a minimum rank of {newArmor.EquipmentRank} to equip it");
            }
        }
        #endregion
    }
}