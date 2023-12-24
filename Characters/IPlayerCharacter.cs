using System;

namespace GameCharacters
{
    interface IPlayerCharacter
    {
        string Name { get; }
        int HP { get; }
        int DefaultOffense { get; }
        int DefaultDefense { get; }
        int InitialGold { get; }

        int AttackPhase(int defPow, int weaponPow);
        int DefensePhase(int defDef, int shieldDef, int armorDef);
    }
}