using System; 

namespace GameCharacters
{
    class Hero : ICharacter
    {
        public enum Rank
        {
            C,
            B,
            A,
            S
        }
        public string Name { get; internal set; }
        public int HP { get; internal set; } = 100;
        public int DefaultOffense { get; private set; } = 5;
        public int DefaultDefense { get; private set; } = 5;
        public Rank HeroRank { get; internal set; } = Rank.C;
        public int InitialGold { get; internal set; } = 100;

        public Hero(string name)
        {
            this.Name = name;
        }
    }
}