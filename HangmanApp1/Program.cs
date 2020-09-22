using System;

namespace HangmanApp1
{
    public static class Hangman
    {
        public static int Contains(string a,string b)
        {
            for (int i = 0; i < (b.Length); i++)
            {
                if (a == b.Substring(i))
                {
                    return i;
                }
            }

            return -1;
        }

        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            string letterChoice = "g";
            string wordActual = "Begin";
            int ret;
            ret = Contains(letterChoice, wordActual);
            if (ret != -1)
            {
                Console.WriteLine("You guessed the "+(ret+1)+" Character correctly");
            }
            else if (ret == -1)
            {
                Console.WriteLine("You guessed incorrectly");
            }
            
        }
    }
}