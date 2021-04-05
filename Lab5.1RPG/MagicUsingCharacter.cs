using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
   
    class MagicUsingCharacter : GameCharacter
    {
        private int MagicalEnergy;

        public int MagicEnergy
        {
            get { return MagicalEnergy; }
            set { MagicalEnergy = value; }
        }

        public MagicUsingCharacter(string name, int intelligence, int strength, int magicalEnergy) : base(name, intelligence, strength)
        {

            MagicalEnergy = magicalEnergy;
        }

        public override void Play()
        {
            Console.WriteLine($" {CharacterName} (int {CharacterIntelligence}, Strength {CharacterStrength}, Magic: {MagicEnergy})" );

        }
    }
    
}
