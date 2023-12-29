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
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 2;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1:
                    this.Name = "Iron Sword";
                    this.Damage = 4;
                    this.HasExtraDmg = false;
                    this.PlusDamage = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 3;
                    this.EquipmentPrice = 150;
                    break;
                
                case 2:
                    this.Name = "Steel Sword";
                    this.Damage = 5;
                    this.HasExtraDmg = true;
                    this.PlusDamage = 1;
                    this.EquipmentRank = Rank.B;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 5;
                    this.EquipmentPrice = 350;
                    break;
            }
        }
        #endregion
    }
}