using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
     
    class Wizard : MagicUsingCharacter
    {

        private int SpellNumber;

        public int SpellNum
        {
            get { return SpellNumber; }
            set { SpellNumber = value; }
        }
        public Wizard(string name, int intelligence, int strength, int magicalEnergy,  int spellNumber) : base(name, intelligence, strength, magicalEnergy)
        {
            SpellNumber = spellNumber;
        }

        public override void Play()
        {
            Console.WriteLine($"{CharacterName} (int {CharacterIntelligence}, strength {CharacterStrength}, magic {MagicEnergy}) {SpellNum} spells");

        }


    }
    
}
