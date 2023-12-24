using System;

namespace GameCharacters
{
    interface IMonster
    {
        int MonsterID { get; }
        string Name { get; }
        int HP { get; }
        int DefaultDefense { get; }
        int DefaultOffense { get; }
        int GoldDrop { get; }
    }
}