using System;

namespace Equipment
{
    interface IEquipment
    {
        string Name { get; }
        int EquipmentWeight { get; }
        int EquipmentPrice { get; }
    }
}