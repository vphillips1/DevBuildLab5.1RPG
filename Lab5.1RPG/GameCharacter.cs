using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5._1RPG
{
    class GameCharacter
    {
               
        private string Name;
        private int Intelligence;
        private int Strength;
       


        public string CharacterName
        {
            get { return Name; }
            set { Name = value; }
        }

        public int CharacterIntelligence
        {
            get { return Intelligence; }
            set { Intelligence = value; }
        }

        public int CharacterStrength
        {
            get { return Strength; }
            set { Strength = value; }
        }

       


        public GameCharacter(string name, int intelligence, int strength)
        {
            Name = name;
            Intelligence = intelligence;
            Strength = strength;
           
        }
        public virtual void Play()
        {

        }
    }
    
}
