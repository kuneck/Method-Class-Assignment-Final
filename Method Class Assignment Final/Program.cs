using System;

namespace Method_Class_Assignment_Final
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MarvelCharacter class
            MarvelCharacter ironMan = new MarvelCharacter("Iron Man");
            MarvelCharacter captainAmerica = new MarvelCharacter("Captain America");

            //Call the Battle method, passing in the parameters normally
            Console.WriteLine("First Battle:");
            ironMan.Battle(100, 80);

            //Call the Battle method, specifying the parameters by name
            Console.WriteLine("\nSecond Battle:");
            captainAmerica.Battle(attackValue: 90, defenseValue: 70);

            // Keep the console window open until a key is pressed
            Console.ReadLine();
        }
    }
}
