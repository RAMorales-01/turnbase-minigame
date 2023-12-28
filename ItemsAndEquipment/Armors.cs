using System;
using RankLevels;

namespace Equipment
{
    abstract class PlayerProtection : IEquipment
    {
        public string Name { get; protected set; } = string.Empty;
        public int Defense { get; protected set; }
        public bool HasExtraDef { get; protected set; }
        public int PlusDefense { get; protected set; }
        public Rank EquipmentRank { get; internal set; }
        public string EquipmentInfo { get; protected set; } = string.Empty;
        public int EquipmentWeight { get; protected set; }
        public int EquipmentPrice { get; protected set; }
    }
    internal class Armor : PlayerProtection
    {
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
            }
        }
    }
    internal class Shield : PlayerProtection 
    {
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
            }
        }
    }
}