using System;

namespace GameCharacters
{
    interface IMonster
    {
        string Name { get; }
        int HP { get; }
        int DefaultDefense { get; }
        int DefaultOffense { get; }
        int GoldDrop { get; }
    }
}