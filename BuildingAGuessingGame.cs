using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Lesson_One
{
    internal class BuildingAGuessingGame
    {
        public static void GuessGame()
        {
            string secretWord = "professional";
            string GuessedWord = "";
            int guessCount = 0;
            int guessLimit = 3;
            bool outofLives = false;

            while (GuessedWord != secretWord && !outofLives)
            {
                if (guessCount < guessLimit)
                {
                    Console.WriteLine("Enter the Guessing Word:");
                    GuessedWord = Console.ReadLine();
                    guessCount++;
                }
                else
                {
                    outofLives = true;
                }
            }

            if (outofLives)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("You Win!");
            }
        }
    }
}
