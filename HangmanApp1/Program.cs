using System;
using System.Text;

namespace HangmanApp1
{
    public class Hangman
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

        static void enteringWord() // Ben's part
        {
            string[] wordArray = {"Apple", "Banana", "Orange"};

            Random random = new Random();
            int randomNo = random.Next(3);
            string hangmanWord = wordArray[randomNo];

            string underscoredWord = new String('_', hangmanWord.Length);
            Console.WriteLine("Guess the word:\n" + underscoredWord);

            bool typo = true;
            string guessedWord = "";

            //User enters his guess
            while (typo == true)
            {
                Console.WriteLine("Please enter your guess:");
                guessedWord = Console.ReadLine().Trim();

                if (guessedWord.Length == 1)
                {
                    typo = false;
                }
                else if (guessedWord.Length < 1)
                {
                    Console.WriteLine("You did not enter anything");
                }
                else
                {
                    Console.WriteLine("You entered more than one character");
                }
            }
        }

        public static void Main(string[] args)
        {
            // Ben           - enter the words and allow user to choose
            // Ollie TJ      - function that loops through the word to see where letters are
            // Ollie Blom    - Main while loop
            
            enteringWord();
            
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