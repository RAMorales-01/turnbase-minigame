using System;

namespace Equipment
{
    abstract class Item : IConsumables
    {
        public enum PotionLevels
        {
            C = 25, 
            B = 50,
            A = 100,
        }
        public string Name { get; protected set; } = string.Empty;
        public int HealLvl { get; protected set; }
        public string ItemDescription { get; protected set; } = string.Empty;
        public int ItemPrice { get; protected set; }
    }
    internal class HealingItems : Item
    {
        public HealingItems(int p)
        {
            switch(p)
            {
                case 1:
                    this.Name = "Lesser Potion";
                    this.HealLvl = (int)PotionLevels.C;
                    this.ItemDescription = "Heals 25 of HP";
                    this.ItemPrice = 50;
                    break;

                case 2:
                    this.Name = "Medium Potion";
                    this.HealLvl = (int)PotionLevels.B;
                    this.ItemDescription = "Heals 50 of HP";
                    this.ItemPrice = 100;
                    break;
                
                case 3:
                    this.Name = "High Potion";
                    this.HealLvl = (int)PotionLevels.A;
                    this.ItemDescription = "Heals 100 of HP";
                    this.ItemPrice = 250;
                    break;
            }
        }
    }
}