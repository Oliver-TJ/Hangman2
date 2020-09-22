using System;
using System.Diagnostics.PerformanceData;

namespace HangmanApp1
{
    public static class Hangman
    {
        public static int[] CheckGuess(char a,string b)
        {
            int[] positions = new int[b.Length];
            bool contain = false;
            for (int i = 0; i < (b.Length); i++)
            {
                if (b[i] == a)
                {
                    positions[i] = 1;
                }
                else
                {
                    positions[i] = -1;
                }
                //positions[i] = b.IndexOf(a, i, i);
            }

            return positions;
        }

        public static string WordEntry()
        {
            Console.WriteLine("Enter the word you would like someone to guess: ");
            return Console.ReadLine();
        }

        public static void GameLoop()
        {
           string word = WordEntry();
           //Console.WriteLine(word);
           int counter = word.Length;
           while (counter > 0)
           {
               Console.WriteLine("Enter your guess: ");
               char guess = Convert.ToChar(Console.ReadLine());
               int[] guessPositions = CheckGuess(guess, word);
               for (int i = 0; i < (word.Length); i++)
               {
                   Console.WriteLine(guessPositions[i]);
               }
               Console.WriteLine(Convert.ToString(CheckGuess(guess, word)));
               /*if (Contains(guess, word) == -1)
               {
                   Console.WriteLine("You guessed the "+(ret+1)+" Character correctly");
               }
               else if (ret == -1)
               {
                   Console.WriteLine("You guessed incorrectly");
               }
               */
           }
        }

        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            string letterChoice = "n";
            string wordActual = "Beginning";
            GameLoop();
            /* int ret;
            ret = Contains(letterChoice, wordActual);
            if (ret != -1)
            {
                Console.WriteLine("You guessed the "+(ret+1)+" Character correctly");
            }
            else if (ret == -1)
            {
                Console.WriteLine("You guessed incorrectly");
            }
            */
        }
    }
}