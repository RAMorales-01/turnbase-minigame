using System;

namespace GameCharacters
{
    interface ICharacter
    {
        string Name { get; }
        int HP { get; }
        int DefaultOffense { get; }
        int DefaultDefense { get; }
    }
}