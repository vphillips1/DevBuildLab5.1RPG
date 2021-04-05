using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
   
    class Warrior : GameCharacter
    {

        private string WeaponType;

        public string Weapon
        {
            get { return WeaponType; }
            set { WeaponType = value; }
        }

        public Warrior(string name, int intelligence, int strength,  string weaponType) : base(name, strength, intelligence)
        {
            WeaponType = weaponType;
        }

        public override void Play()
        {
            Console.WriteLine($" {CharacterName} (int {CharacterIntelligence}, Strength {CharacterStrength}) {Weapon}");

        }
    }
}
