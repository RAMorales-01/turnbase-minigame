using System;

namespace Equipment
{
    interface IEquipment
    {
        enum Rank
        {
            C,
            B,
            A,
            S
        } 
        string Name { get; }
        int EquipmentWeight { get; }
        int EquipmentPrice { get; }
    }
}