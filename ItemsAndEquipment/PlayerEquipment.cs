using System;
using RankLevels;

namespace Equipment
{
    abstract class PlayerEquipment : IEquipment
    {
        public string Name { get; protected set; } = string.Empty;
        public Rank EquipmentRank { get; internal set; }
        public string EquipmentInfo {get; protected set; } = string.Empty;
        public int EquipmentWeight { get; protected set; }
        public int EquipmentPrice { get; protected set; }

        protected PlayerEquipment(string name, Rank rank, string info, int weight, int price)
        {
            this.Name = name;
            this.EquipmentRank = rank;
            this.EquipmentInfo = info;
            this.EquipmentWeight = weight;
            this.EquipmentPrice = price;
        }
    }
    abstract class PlayerOffensiveEq : PlayerEquipment
    {
        public int Damage { get; protected set; }
        public bool HasExtraDmg { get; protected set; }
        public int PlusDamage { get; protected set; }

        public PlayerOffensiveEq(string name, Rank rank, string info, int weight, int price, int dmg, bool hasExtra, int plusDmg) : base(name, rank, info, weight, price)
        {
            this.Damage = dmg;
            this.HasExtraDmg = hasExtra;
            this.PlusDamage = plusDmg;
        }
    }
    abstract class PlayerDefensiveEq : PlayerEquipment
    {
        public int Protection { get; protected set; }
        public bool HasExtraDef { get; protected set; }
        public int PlusDefense { get; protected set; }

        public PlayerDefensiveEq(string name, Rank rank, string info, int weight, int price, int protection, bool hasExtra, int plusProtection) : base(name, rank, info, weight, price)
        {
            this.Protection = protection;
            this.HasExtraDef = hasExtra;
            this.PlusDefense = plusProtection;
        }
    }
}