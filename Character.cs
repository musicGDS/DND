using System;
namespace DnD
{
    public class Character
    {
        public string Name { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Constitution { get; set; }
        public int Intelligence { get; set; }
        public int Wisdom { get; set; }
        public int Charisma { get; set; }
        public int Hitpoints { get; set; }
        public Character(string name, int strength, int dexterity, int constitution,
                        int intelligence, int wisdom, int charisma)
        {
            Name = name;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Constitution = constitution;
            this.Intelligence = intelligence;
            this.Wisdom = wisdom;
            this.Charisma = charisma;
            Hitpoints = constitution * 10;
        }
    }

}