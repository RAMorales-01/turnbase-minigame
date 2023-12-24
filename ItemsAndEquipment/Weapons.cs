using System;

namespace Equipment
{
    abstract class Weapon : IEquip
    {
        private char _type;
        private string _name = string.Empty;
        private int _attackValue;
        private string _wpnEffect = string.Empty;
        private int _wpnPlusDamage;
        private int _equipmentWeight;
        private int _equipmentPrice;

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
        public int AttackValue
        {
            get { return _attackValue; }
            protected set { _attackValue = value; }
        }
        public string WpnEffect
        {
            get { return _wpnEffect; }
            protected set { _wpnEffect = value; }
        }
        public int WpnPlusDamage
        {
            get { return _wpnPlusDamage; }
            protected set { _wpnPlusDamage = value; }
        }
        public int EquipmentWeight
        {
            get { return _equipmentWeight; }
            protected set { _equipmentWeight = value; }
        }
        public int EquipmentPrice
        {
           get { return _equipmentPrice; }
           protected set { _equipmentPrice = value; } 
        }
    }
    internal class Sword : Weapon 
    {
        public Sword(int wpnRarity)
        {
            switch(wpnRarity)
            {
                case 0:
                    this.Type = 'W';
                    this.Name = "Wooden Sword";
                    this.AttackValue = 1;
                    this.WpnEffect = "None";
                    this.EquipmentWeight = 2;
                    this.EquipmentPrice = 0; 
                    break;
                
                case 1:
                    this.Type = 'W';
                    this.Name = "Iron Sword";
                    this.AttackValue = 4;
                    this.WpnEffect = "None";
                    this.EquipmentWeight = 5;
                    this.EquipmentPrice = 50; 
                    break;
                
                case 2:
                    this.Type = 'W';
                    this.Name = "Steel Sword";
                    this.AttackValue = 5;
                    this.WpnEffect = "+1 dmg to goblins.";
                    this.WpnPlusDamage = 1;
                    this.EquipmentWeight = 8;
                    this.EquipmentPrice = 150; 
                    break;
            }
        }
    }
}