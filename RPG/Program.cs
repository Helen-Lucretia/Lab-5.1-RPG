using System;
using System.Collections.Generic;

namespace RPG
{
    class gameCharacter
    {
        private string gamerName;
        private int gamerStrength;
        private int gamerIntelligence;
        public gameCharacter(string name, int strength, int intelligence)
        {
            gamerName = name;
            gamerStrength = strength;
            gamerIntelligence = intelligence;
        }
        public void setGamerName(string name)
        {
            gamerName = name;
        }
        public string getGamerName()
        {
            return gamerName;
        }
        public void setGamerStrength(int strength)
        {
            gamerStrength = strength;
        }
        public int getGamerStrength()
        {
            return gamerStrength;
        }
        public void setGamerIntelligence(int intelligence)
        {
            gamerIntelligence = intelligence;
        }
        public int getGamerIntelligence()
        {
            return gamerIntelligence;
        }
        public virtual string Play()
        {
            return $"Name: {gamerName}: (Intelligence Level: {gamerIntelligence}, Strength Level: {gamerStrength})";
        }
    }
    class magicUsingCharacter : gameCharacter
    {
        public magicUsingCharacter(string name, int strength, int intelligence, int energy) : base (name, strength, intelligence)
            {
                magicalEnergy = energy;
            }
        public int magicalEnergy;

        public override string Play()
        {
            return $"Name: {getGamerName()}: (Intelligence Level: {getGamerIntelligence()}, Strength Level: {getGamerStrength()}) Magic Level: {magicalEnergy}";
        }
    }
    class warrior : gameCharacter
    {
        public warrior(string name, int strength, int intelligence, string weapon) : base(name, strength, intelligence)
        {
            weaponType = weapon;
        }
        public string weaponType;
        public override string Play()
        {
            return $"Name: {getGamerName()}: (Intelligence Level: {getGamerIntelligence()}, Strength Level: {getGamerStrength()}) Weapon Type: {weaponType}";
        }
    }
    class wizard : magicUsingCharacter
    {
        public wizard(string name, int strength, int intelligence, int energy, int spells) : base (name, strength, intelligence, energy)
        {
            spellNumber = spells;
        }
        public int spellNumber;
        public override string Play()
        {
           return $"Name: {getGamerName()}: (Intelligence Level: {getGamerIntelligence()}, Strength Level: {getGamerStrength()}) Magic Level: {magicalEnergy} Spells: {spellNumber}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<gameCharacter> characters = new List<gameCharacter>();
            characters.Add(new warrior("Shadowshout", 10, 15, "sword"));
            characters.Add(new warrior("Rumblebow", 5, 20, "saw"));
            characters.Add(new wizard("Anell", 15, 15, 100, 6));
            characters.Add(new wizard("Izith", 15, 20, 50, 4 ));
            characters.Add(new wizard("Azin", 11, 17, 75, 1));


            Console.WriteLine("Welcome to World of Dev.BuildCraft!");

            for (int i = 0; i < characters.Count; i++)
            {
                Console.WriteLine(characters[i].Play());
            }
        }
    }
}
