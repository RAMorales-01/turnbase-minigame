using System;

namespace Equipment
{
    abstract class Item : IConsumables
    {
        private char _type;
        private string _name = string.Empty;
        private string _description = string.Empty;
        private int _useValue;
        private int _itemPrice;

        public char Type 
        {
            get { return _type; }
            protected set { _type = value; }
        }
        public string Name
        {
            get { return _name; }
            protected set { _name = value; }
        }
        public string Description
        {
            get { return _description; }
            protected set { _description = value; }
        }
        public int UseValue
        {
            get { return _useValue; }
            protected set { _useValue = value; }
        }
        public int ItemPrice
        {
            get { return _itemPrice; }
            protected set { _itemPrice = value; }
        }
    }
    internal class HealingItems : Item
    {
        public HealingItems(int p)
        {
            switch(p)
            {
                case 1:
                    this.Type = 'P';
                    this.Name = "Lesser Potion";
                    this.Description = "Heals 25 points HP.";
                    this.UseValue = 25;
                    this.ItemPrice = 50;
                    break;

                case 2:
                    this.Type = 'P';
                    this.Name = "Medium Potion";
                    this.Description = "Heals 50 points HP.";
                    this.UseValue = 50;
                    this.ItemPrice = 100;
                    break;
                
                case 3:
                    this.Type = 'P';
                    this.Name = "Full Potion";
                    this.Description = "Heals 100 points HP.";
                    this.UseValue = 100;
                    this.ItemPrice = 250;
                    break;
            }
        }
    }
    internal class ThrowItems : Item
    {
        public ThrowItems(int t)
        {
            switch(t)
            {
                case 1:
                    this.Type = 'T';
                    this.Name = "Small Bomb";
                    this.Description = "10 points of damage to the enemy";
                    this.UseValue = 10;
                    this.ItemPrice = 25;
                    break;
                
                case 2:
                    this.Type = 'T';
                    this.Name = "Throwing Knife";
                    this.Description = "5 points of damage to the enemy";
                    this.UseValue = 5;
                    this.ItemPrice = 10;
                    break;
                
                case 3:
                    this.Type = 'T';
                    this.Name = "Fire Bomb";
                    this.Description = "50 points of damage to the enemy";
                    this.UseValue = 50;
                    this.ItemPrice = 150;
                    break;
            }
        }
    }
}