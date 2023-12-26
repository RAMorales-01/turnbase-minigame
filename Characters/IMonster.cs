using System;

namespace GameCharacters
{
    interface IMonster
    {
        enum Rank 
        {
            C,
            B,
            A,
            S,
            Boss
        }
        string Name { get; }
        int HP { get; }
        int DefaultDefense { get; }
        int DefaultOffense { get; }
        int GoldDrop { get; }
    }
}