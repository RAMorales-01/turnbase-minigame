using System;

namespace Equipment
{
    abstract class Armor : IEquip
    {
        private char _type;
        private string _name = string.Empty;
        private int _defenseValue;
        private string _armEffect = string.Empty;
        private int _armPlusProtection;
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
        public int DefenseValue
        {
            get { return _defenseValue; }
            protected set { _defenseValue = value; }
        }
        public string ArmEffect
        {
            get { return _armEffect; }
            protected set { _armEffect = value; }
        }
        public int ArmPlusProtection
        {
            get { return _armPlusProtection; }
            protected set { _armPlusProtection = value; }
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
    internal class LightArmor : Armor 
    {
        public LightArmor(int armorLvl)
        {
            switch(armorLvl)
            {
                case 0:
                    this.Type = 'A';
                    this.Name = "Leather Armor";
                    this.DefenseValue = 2;
                    this.ArmEffect = "None";
                    this.EquipmentWeight = 5;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1:
                    this.Type = 'A';
                    this.Name = "Iron Armor";
                    this.DefenseValue = 4;
                    this.ArmEffect = "None";
                    this.EquipmentWeight = 10;
                    this.EquipmentPrice = 100;
                    break;
                
                case 2:
                    this.Type = 'A';
                    this.Name = "Steel Armor";
                    this.DefenseValue = 5;
                    this.ArmEffect = "+1 protection from Kobolds";
                    this.ArmPlusProtection = 1;
                    this.EquipmentWeight = 15;
                    this.EquipmentPrice = 200;
                    break;
            }
        }
    }
    internal class Shield : Armor 
    {
        public Shield(int armorLvl)
        {
            switch(armorLvl)
            {
                case 0: 
                    this.Type = 'A';
                    this.Name = "Tin Shield";
                    this.DefenseValue = 1;
                    this.ArmEffect = "None";
                    this.EquipmentWeight = 2;
                    this.EquipmentPrice = 0;
                    break;
                
                case 1: 
                    this.Type = 'A';
                    this.Name = "Leather Shield";
                    this.DefenseValue = 2;
                    this.ArmEffect = "+1 protection from goblins";
                    this.ArmPlusProtection = 1;
                    this.EquipmentWeight = 4;
                    this.EquipmentPrice = 100;
                    break;
                
                case 2: 
                    this.Type = 'A';
                    this.Name = "Iron Shield";
                    this.DefenseValue = 5;
                    this.ArmEffect = "None";
                    this.EquipmentWeight = 6;
                    this.EquipmentPrice = 150;
                    break;
            }
        }
    }
}