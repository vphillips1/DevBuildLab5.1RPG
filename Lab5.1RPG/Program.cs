using System;
using System.Collections.Generic;

namespace Lab5._1RPG
{
    class Program
    {

        static void PlayGame()
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();

            gameCharacters.Add(new Warrior("Tharg the Barbarian", 9, 20, "Axe"));
            gameCharacters.Add(new Warrior("Captain America", 16, 21, "shield"));
            gameCharacters.Add(new Warrior("Spiderman", 20, 19, "web"));
            gameCharacters.Add(new Wizard("Harry Potter", 21, 12, 10, 9));

            Console.WriteLine("Welcome to World Dev.Buildcraft!\n");


            foreach (GameCharacter characters in gameCharacters)
            {
                characters.Play();
                Console.WriteLine();
            }
        }


        static void Main(string[] args)
        {

            PlayGame();
         
        }
    }
    

   

    
    

    

   






}
