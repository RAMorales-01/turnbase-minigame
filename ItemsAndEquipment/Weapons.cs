using System;
using RankLevels;

namespace Equipment
{
    abstract class PlayerOffense : IEquipment
    {
        #region Weapon class properties
        public string Name { get; protected set; } = string.Empty;
        public int Damage { get; protected set; }
        public bool HasExtraDmg { get; protected set; }
        public int PlusDamage { get; protected set; }
        public Rank EquipmentRank { get; internal set; }
        public string EquipmentInfo { get; protected set; } = string.Empty;
        public int EquipmentWeight { get; protected set; }
        public int EquipmentPrice { get; protected set; }
        #endregion
    }
    internal class Sword : PlayerOffense 
    {
        #region Posible weapon constructors
        public Sword(int swordLvl)
        {
            switch(swordLvl)
            {
                case 0:
                    this.Name = "Rusted Sword";
                    this.Damage = 2;
                    this.HasExtraDmg = false;
                    this.PlusDamage = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = "Sword covered in rust, it is in very bad shape";
                    this.EquipmentWeight = 2;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1:
                    this.Name = "Iron Sword";
                    this.Damage = 4;
                    this.HasExtraDmg = false;
                    this.PlusDamage = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = "Sword made of the highest quality iron, perfect for beginners";
                    this.EquipmentWeight = 4;
                    this.EquipmentPrice = 150;
                    break;
                
                case 2:
                    this.Name = "Steel Sword";
                    this.Damage = 5;
                    this.HasExtraDmg = true;
                    this.PlusDamage = 1;
                    this.EquipmentRank = Rank.B;
                    this.EquipmentInfo = "Sword made of steel forged on high temperature, +1 of extra dmg";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 350;
                    break;
                
                case 3:
                    this.Name = "Mithril Sword";
                    this.Damage = 8;
                    this.HasExtraDmg = true;
                    this.PlusDamage = 2;
                    this.EquipmentRank = Rank.A;
                    this.EquipmentInfo = "Sword made of the mythical material forged by the elven smiths, +2 of extra dmg";
                    this.EquipmentWeight = 5;
                    this.EquipmentPrice = 850; 
                    break;
                
                case 4: 
                    this.Name = "Dragonlord Sword";
                    this.Damage = 10;
                    this.HasExtraDmg = true;
                    this.PlusDamage = 3;
                    this.EquipmentRank = Rank.S;
                    this.EquipmentInfo = "Sword used by the lord of the dragons, only the strongest warriors can use this blade, +3 of extra dmg";
                    this.EquipmentWeight = 8;
                    this.EquipmentPrice = 1000;
                    break;

                case 5:
                    this.Name = "Soulrender Sword";
                    this.Damage = 10;
                    this.HasExtraDmg = true;
                    this.PlusDamage = 5;
                    this.EquipmentRank = Rank.SS;
                    this.EquipmentInfo = "Sword of legend known as the slayer of gods, strong as a hurricane light as a feather, +5 of extra dmg";
                    this.EquipmentWeight = 1;
                    this.EquipmentPrice = 5000;
                    break;
            }
        }
        #endregion
    }
}