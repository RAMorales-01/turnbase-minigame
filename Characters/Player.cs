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
        public int HP { get; private set; }
        public int DefaultOffense { get; private set; }
        public int DefaultDefense { get; private set; }
        public Rank HeroRank { get; internal set; }
        public int InitialGold { get; internal set; }

        public Hero(string name)
        {
            this.Name = name;
            this.HP = 100;
            this.DefaultOffense = 5;
            this.DefaultDefense = 5;
            this.HeroRank = Rank.C;
            this.InitialGold = 100;
        }
    }
}