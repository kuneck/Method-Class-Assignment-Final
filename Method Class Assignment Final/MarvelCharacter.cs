using System;

namespace Method_Class_Assignment_Final
{
    //Create a class
    public class MarvelCharacter
    {
        public string Name { get; set; }

        // Constructor that initializes the character's name
        public MarvelCharacter(string name)
        {
            Name = name;
        }

        //Create a void method that takes two integers as parameters.
        //The method performs a math operation on the first integer and displays the second integer on the screen.
        public void Battle(int attackValue, int defenseValue)
        {
            //Perform a math operation on the attack value
            int enhancedAttack = (int)(attackValue * 1.5);

            //Display the result
            Console.WriteLine(Name + " enhanced attack value: " + enhancedAttack);

            //Display the opponent's defense value
            Console.WriteLine(Name + " opponent's defense value: " + defenseValue);
        }
    }
}
