using System;

namespace Equipment
{
    interface IConsumables
    {
        char Type { get; }
        string Name { get; }
        int UseValue { get; }
        int ItemPrice { get; }
    }
}