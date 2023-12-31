using System;
using RankLevels;

namespace Equipment
{
    abstract class PlayerProtection : IEquipment
    {
        #region Equipment class properties
        public string Name { get; protected set; } = string.Empty;
        public int Defense { get; protected set; }
        public bool HasExtraDef { get; protected set; }
        public int PlusDefense { get; protected set; }
        public Rank EquipmentRank { get; internal set; }
        public string EquipmentInfo { get; protected set; } = string.Empty;
        public int EquipmentWeight { get; protected set; }
        public int EquipmentPrice { get; protected set; }
        #endregion
    }
    internal class Armor : PlayerProtection
    {
        #region Posible armor constructors
        public Armor(int armorLvl)
        {
            switch(armorLvl)
            {
                case 0:
                    this.Name = "Leather Armor";
                    this.Defense = 2;
                    this.HasExtraDef = true;
                    this.PlusDefense = 1;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 4;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1:
                    this.Name = "Iron Armor";
                    this.Defense = 5;
                    this.HasExtraDef = false;
                    this.PlusDefense = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 250;
                    break;
                
                case 2:
                    this.Name = "Steel Armor";
                    this.Defense = 8;
                    this.HasExtraDef = false;
                    this.PlusDefense = 0;
                    this.EquipmentRank = Rank.B;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 8;
                    this.EquipmentPrice = 400;
                    break;
                
                case 3:
                    this.Name = "Mithril Armor";
                    this.Defense = 10;
                    this.HasExtraDef = true;
                    this.PlusDefense = 2;
                    this.EquipmentRank = Rank.A;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 800;
                    break;
                
                case 4:
                    this.Name = "Dragon Knight Armor";
                    this.Defense = 12;
                    this.HasExtraDef = true;
                    this.PlusDefense = 2;
                    this.EquipmentRank = Rank.A;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 10;
                    this.EquipmentPrice = 1800;
                    break;
                
                case 5:
                    this.Name = "Luminary Armor";
                    this.Defense = 15;
                    this.HasExtraDef = true;
                    this.PlusDefense = 5;
                    this.EquipmentRank = Rank.S;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 1;
                    this.EquipmentPrice = 10000;
                    break;
            }
        }
        #endregion
    }
    internal class Shield : PlayerProtection 
    {
        #region Posible shield constructors
        public Shield(int shieldLvl)
        {
            switch(shieldLvl)
            {
                case 0: 
                    this.Name = "Leather Shield";
                    this.Defense = 1;
                    this.HasExtraDef = false;
                    this.PlusDefense = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 2;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1: 
                    this.Name = "Iron Shield";
                    this.Defense = 2;
                    this.HasExtraDef = false;
                    this.PlusDefense = 0;
                    this.EquipmentRank = Rank.C;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 3;
                    this.EquipmentPrice = 50;
                    break;
                
                case 2: 
                    this.Name = "Steel Shield";
                    this.Defense = 4;
                    this.HasExtraDef = true;
                    this.PlusDefense = 1;
                    this.EquipmentRank = Rank.B;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 4;
                    this.EquipmentPrice = 250;
                    break;

                case 3: 
                    this.Name = "Mithril Shield";
                    this.Defense = 5;
                    this.HasExtraDef = true;
                    this.PlusDefense = 2;
                    this.EquipmentRank = Rank.A;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 500;
                    break;
                
                case 4:
                    this.Name = "Dragon Knight Shield";
                    this.Defense = 6;
                    this.HasExtraDef = true;
                    this.PlusDefense = 2;
                    this.EquipmentRank = Rank.A;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 1000;
                    break;

                case 5:
                    this.Name = "Lunar Shield";
                    this.Defense = 7;
                    this.HasExtraDef = true;
                    this.PlusDefense = 3;
                    this.EquipmentRank = Rank.S;
                    this.EquipmentInfo = " ";
                    this.EquipmentWeight = 1;
                    this.EquipmentPrice = 2500;
                    break;
            }
        }
        #endregion
    }
}