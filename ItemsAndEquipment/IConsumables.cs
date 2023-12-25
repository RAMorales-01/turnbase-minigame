using System;

namespace Equipment
{
    interface IConsumables
    {
        enum Rank
        {
            C,
            B,
            A
        }
        string Name { get; }
        int ItemPrice { get; }
    }
}