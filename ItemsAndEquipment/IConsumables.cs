using System;

namespace Equipment
{
    interface IConsumables
    {
        enum PotionLevels
        {
            C,
            B,
            A
        }
        string Name { get; }
        int ItemPrice { get; }
    }
}