using System;

namespace Equipment
{
    interface IEquip
    {
        char Type { get; }
        string Name { get; }
        int EquipmentWeight { get; }
        int EquipmentPrice { get; }
    }
}